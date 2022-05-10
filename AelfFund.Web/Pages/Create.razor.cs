using AelfFund.Web.Models;
using AelfFund.Web.Services;
using Microsoft.AspNetCore.Components;

namespace AelfFund.Web.Pages
{
    public partial class Create
    {
        [Inject]
        public ChainService ChainService { get; set; } = default!;

        public CreateProjectModel Model { get; set; } = new();

        public async Task ConnectWallet()
        {
            await ChainService.ConnectOrInstallWalletAsync();
            StateHasChanged();
        }

        public async Task AddProject()
        {
            if(!string.IsNullOrEmpty(Model.Name)
                && !string.IsNullOrEmpty(Model.Description)
                && Model.FundGoal > 1
                )
            {
                await ChainService.AddProject(Model);

            }
        }

    }
}
