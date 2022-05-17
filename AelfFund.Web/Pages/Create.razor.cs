using AelfFund.Web.Models;
using AelfFund.Web.Services;
using Microsoft.AspNetCore.Components;

namespace AelfFund.Web.Pages
{
    public partial class Create
    {
        [Inject]
        public ChainService ChainService { get; set; } = default!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

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
                var project = await ChainService.AddProject(Model);

                NavigationManager.NavigateTo($"project/{project.Id}");

            }
        }

    }
}
