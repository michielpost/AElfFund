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
        private readonly UserViewModel userViewModel;
        private static List<ProjectModel> projects = new List<ProjectModel>()
            {
                new ProjectModel()
                {
                    Id = "1",
                    Name = "aelf CYBER Metaverse",
                    Description = "The aelf CYBER Metaverse will feature a cyber cafe where you can play games and talk to other visitors in the Metaverse. We need funding to hire a designer to make it look really great.",
                    FundGoal = 7500
                },
                new ProjectModel()
                {
                    Id = "2",
                    Name = "Betting DAO",
                    Description = "This Betting DAO will offer betting games. All profit will go directly to the DAO and will be used to fund the development of new games.",
                    FundGoal = 50000
                }
        };

        private static List<Funder> funders = new List<Funder>()
            {
                new Funder
                {
                    Address = "qBRsMbWWK7fWDXfJUrTSttQUv9AgvJhnH3YeYSecc2Vryy4b",
                    Amount = 50m,
                    ProjectId = "1",
                },
                new Funder
                {
                    Address = "2X8x84GAUrDf8oJuJL2z7G9sF65aY8pJnvHcmXAUJQBhopePFd",
                    Amount = 150m,
                    ProjectId = "1",
                },
                new Funder
                {
                    Address = "qBRsMbWWK7fWDXfJUrTSttQUv9AgvJhnH3YeYSecc2Vryy4b",
                    Amount = 300m,
                    ProjectId = "1",
                },
                new Funder
                {
                    Address = "qBRsMbWWK7fWDXfJUrTSttQUv9AgvJhnH3YeYSecc2Vryy4b",
                    Amount = 42m,
                    ProjectId = "2",
                },
                new Funder
                {
                    Address = "2X8x84GAUrDf8oJuJL2z7G9sF65aY8pJnvHcmXAUJQBhopePFd",
                    Amount = 139m,
                    ProjectId = "2",
                },
                new Funder
                {
                    Address = "qBRsMbWWK7fWDXfJUrTSttQUv9AgvJhnH3YeYSecc2Vryy4b",
                    Amount = 7m,
                    ProjectId = "2",
                }
            };

        public ChainService(AElfService aelfService, IDialogService DialogService, UserViewModel userViewModel)
        {
            this.aelfService = aelfService;
            dialogService = DialogService;
            this.userViewModel = userViewModel;
        }

        public async Task RefreshViewModel()
        {
            userViewModel.HasExtension = await HasNightElfAsync();
            userViewModel.IsConnected = await IsConnectedAsync();

            if (userViewModel.IsConnected)
                userViewModel.Address = await GetAddressAsync();
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

                funders.Insert(0, new Funder()
                {
                    Address = user,
                    Amount = fund,
                    ProjectId = id
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

            foreach (var funder in result)
            {
                funder.ProjectName = projects.Where(x => x.Id == funder.ProjectId).Select(x => x.Name).FirstOrDefault();
            }

            return Task.FromResult<List<Funder>>(result);
        }

        internal Task<List<Funder>?> GetFundersForProject(string id)
        {
            var result = funders.Where(x => x.ProjectId == id).ToList();

            foreach(var funder in result)
            {
                funder.ProjectName = projects.Where(x => x.Id == funder.ProjectId).Select(x => x.Name).FirstOrDefault();
            }

            return Task.FromResult<List<Funder>?>(result);
        }

        public Task<ProjectModel?> GetProject(string id)
        {
            var project = projects.Where(x => x.Id == id).FirstOrDefault();

            if (project != null)
                project.FundCurrent = funders.Where(x => x.ProjectId == id).Sum(x => x.Amount);

            return Task.FromResult<ProjectModel?>(project);
        }

        public async Task<BalanceResult?> GetBalanceAsync()
        {
            var result = await aelfService.GetBalanceAsync();
            return result;
        }

    }
}
