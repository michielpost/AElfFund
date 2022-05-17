using AElfBlazor;
using AElfBlazor.Models;
using AelfFund.Web.Models;
using AelfFund.Web.Shared;
using Microsoft.JSInterop;
using MudBlazor;

namespace AelfFund.Web.Services
{

    public class ChainService
    {
        private readonly AElfService aelfService;
        private readonly IDialogService dialogService;

        private static List<ProjectModel> projects = new List<ProjectModel>()
            {
                new ProjectModel()
                {
                    Id = "1",
                    Name = "Test",
                    Description = "Test desc",
                    FundGoal = 1000
                },
                new ProjectModel()
                {
                    Id = "2",
                    Name = "Test 2",
                    Description = "Test desc 2",
                    FundGoal = 1000
                }
        };

        private static List<Funder> funders = new List<Funder>()
            {
                new Funder
                {
                    Address = "qBRsMbWWK7fWDXfJUrTSttQUv9AgvJhnH3YeYSecc2Vryy4b",
                    Amount = 50m,
                    Project = "1",
                },
                new Funder
                {
                    Address = "2X8x84GAUrDf8oJuJL2z7G9sF65aY8pJnvHcmXAUJQBhopePFd",
                    Amount = 150m,
                    Project = "1",
                },
                new Funder
                {
                    Address = "qBRsMbWWK7fWDXfJUrTSttQUv9AgvJhnH3YeYSecc2Vryy4b",
                    Amount = 300m,
                    Project = "1",
                },
                new Funder
                {
                    Address = "qBRsMbWWK7fWDXfJUrTSttQUv9AgvJhnH3YeYSecc2Vryy4b",
                    Amount = 42m,
                    Project = "2",
                },
                new Funder
                {
                    Address = "2X8x84GAUrDf8oJuJL2z7G9sF65aY8pJnvHcmXAUJQBhopePFd",
                    Amount = 139m,
                    Project = "2",
                },
                new Funder
                {
                    Address = "qBRsMbWWK7fWDXfJUrTSttQUv9AgvJhnH3YeYSecc2Vryy4b",
                    Amount = 7m,
                    Project = "2",
                }
            };

        public ChainService(AElfService aelfService, IDialogService DialogService)
        {
            this.aelfService = aelfService;
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
            var result = await aelfService.HasNightElfAsync();
            Console.WriteLine($"Installed: {result}");
            return result;
        }

        public async Task Initialize()
        {
            var testnetUrl = "https://explorer-test.aelf.io/chain";

            await aelfService.InitializeNightElfAsync("aelf Funding", testnetUrl);
        }

        internal async Task ConnectOrInstallWalletAsync()
        {
            bool hasNightElf = await HasNightElfAsync();

            if (hasNightElf)
            {
                await Initialize();
                await LoginAsync();
                await RefreshViewModel();
            }
            else
                dialogService.Show<InstallExtensionDialog>("Install NightElf");
        }

        public async Task<bool> IsConnectedAsync()
        {
            var result = await aelfService.IsConnectedAsync();
            Console.WriteLine($"Connected: {result}");
            return result;

        }
        public async Task<string?> LoginAsync()
        {
            var result = await aelfService.LoginAsync();
            await RefreshViewModel();

            Console.WriteLine($"Login: {result}");
            return string.IsNullOrEmpty(result) ? null : result;
        }
        public async Task<string?> GetAddressAsync()
        {
            var result = await aelfService.GetAddressAsync();
            Console.WriteLine($"GetAddress: {result}");
            return string.IsNullOrEmpty(result) ? null : result;
        }
        public async Task LogoutAsync()
        {
            await aelfService.LogoutAsync();
            await RefreshViewModel();
        }

        public Task<List<ProjectModel>> GetProjects()
        {
            var result = projects;

            return Task.FromResult(result);
        }

        internal Task<ProjectModel> AddProject(CreateProjectModel model)
        {
            var project = new ProjectModel()
            {
                Id = Guid.NewGuid().ToString(),
                Name = model.Name,
                Description = model.Description,
                FundGoal = model.FundGoal,
                EndDate = model.EndDate,
                IsActive = true
            };

            projects.Add(project);

            //TODO: Call smart contract

            return Task.FromResult(project);
        }

        internal Task FundProject(string id, string user, decimal fund)
        {
            var project = projects.Where(x => x.Id == id).FirstOrDefault();
            if(project != null)
            {
                project.FundCurrent += fund;

                funders.Add(new Funder()
                {
                    Address = user,
                    Amount = fund,
                    Project = id
                });
            }

            //TODO: Call smart contract

            return Task.CompletedTask;
        }

        internal Task CancelFunding(string id, string user, decimal amount)
        {
            var project = projects.Where(x => x.Id == id).FirstOrDefault();
            if (project != null)
            {
                project.FundCurrent -= amount;
            }

            //TODO: Call smart contract

            return Task.CompletedTask;
        }

        internal Task<List<Funder>> GetFunders()
        {
            var result = funders;

            return Task.FromResult<List<Funder>>(result);
        }

        internal Task<List<Funder>?> GetFundersForProject(string id)
        {
            var result = funders.Where(x => x.Project == id).ToList();

            return Task.FromResult<List<Funder>?>(result);
        }

        public Task<ProjectModel?> GetProject(string id)
        {
            var project = projects.Where(x => x.Id == id).FirstOrDefault();

            if (project != null)
                project.FundCurrent = funders.Where(x => x.Project == id).Sum(x => x.Amount);

            return Task.FromResult<ProjectModel?>(project);
        }

        public async Task<BalanceResult?> GetBalanceAsync()
        {
            var result = await aelfService.GetBalanceAsync();
            return result;
        }

    }
}
