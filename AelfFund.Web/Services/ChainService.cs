using AelfFund.Web.Models;
using AelfFund.Web.Shared;
using Microsoft.JSInterop;
using MudBlazor;

namespace AelfFund.Web.Services
{
    public class ChainService
    {
        private readonly IJSRuntime JS;
        private readonly IDialogService dialogService;

        public ChainService(IJSRuntime js, IDialogService DialogService)
        {
            this.JS = js;
            dialogService = DialogService;
        }

        public async Task RefreshViewModel()
        {
            App.UserViewModel.HasExtension = await HasNightElfAsync();
            App.UserViewModel.IsConnected = await IsConnectedAsync();

            if (App.UserViewModel.IsConnected)
                App.UserViewModel.Address = await GetAddressAsync();
        }

        public async Task<bool> HasNightElfAsync()
        {
            var result = await JS.InvokeAsync<bool>("HasNightElf");
            Console.WriteLine($"Installed: {result}");
            return result;
        }

        internal async Task ConnectOrInstallWalletAsync()
        {
            bool hasNightElf = await HasNightElfAsync();

            if (hasNightElf)
            {
                await LoginAsync();
                await RefreshViewModel();
            }
            else
                dialogService.Show<InstallExtensionDialog>("Install NightElf");
        }

        public async Task<bool> IsConnectedAsync()
        {
            var result = await JS.InvokeAsync<bool>("IsConnected");
            Console.WriteLine($"Connected: {result}");
            return result;

        }
        public async Task<string?> LoginAsync()
        {
            var result = await JS.InvokeAsync<string?>("Login");
            await RefreshViewModel();

            Console.WriteLine($"Login: {result}");
            return string.IsNullOrEmpty(result) ? null : result;
        }
        public async Task<string?> GetAddressAsync()
        {
            var result = await JS.InvokeAsync<string?>("GetAddress");
            Console.WriteLine($"GetAddress: {result}");
            return string.IsNullOrEmpty(result) ? null : result;
        }
        public async Task LogoutAsync()
        {
            await JS.InvokeVoidAsync("Logout");
            await RefreshViewModel();
        }

        public Task<List<ProjectModel>> GetProjects()
        {
            var result = new List<ProjectModel>()
            {
                new ProjectModel()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Test",
                    Description = "Test desc",
                    FundGoal = 1000
                },
                new ProjectModel()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Test 2",
                    Description = "Test desc 2",
                    FundGoal = 1000
                }
            };

            return Task.FromResult(result);
        }

        internal Task AddProject(CreateProjectModel model)
        {
            throw new NotImplementedException();
        }

        internal Task FundProject(string id, decimal fund)
        {
            throw new NotImplementedException();
        }

        internal Task CancelFunding(string project, decimal amount)
        {
            throw new NotImplementedException();
        }

        internal Task<List<Funder>> GetFunders()
        {
            var result = new List<Funder>()
            {
                new Funder
                {
                     Address = "0xTODO",
                      Amount = 13m,
                       Project = "project name global list",
                        TxId = "000xx0x"
                }
            };

            return Task.FromResult<List<Funder>>(result);
        }

        internal Task<List<Funder>?> GetFundersForProject(string id)
        {
            var result = new List<Funder>()
            {
                new Funder
                {
                     Address = "0xTODO",
                      Amount = 13m,
                       Project = "project name",
                        TxId = "000xx0x"
                }
            };

            return Task.FromResult<List<Funder>?>(result);
        }

        public Task<ProjectModel?> GetProject(string id)
        {
            ProjectModel? result = new ProjectModel()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Test from service",
                Description = "Test desc 123",
                FundGoal = 1023m,
                FundCurrent = 150m
            };

            return Task.FromResult<ProjectModel?>(result);
        }

        public async Task<BalanceResult?> GetBalanceAsync()
        {
            var result = await JS.InvokeAsync<BalanceResult?>("GetBalance");
            Console.WriteLine("sym:" + result?.Symbol);
            return result;
        }

        public ValueTask<string> UseFaucetAsync()
        {
            return JS.InvokeAsync<string>("UseFaucet");
        }

        public ValueTask<TransactionStatusResult> GetTxStatus(string txId)
        {
            return JS.InvokeAsync<TransactionStatusResult>("GetTxStatus", txId);
        }
    }
}
