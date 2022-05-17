using AelfFund.Web.Services;
using Microsoft.AspNetCore.Components;

namespace AelfFund.Web.Pages
{
    public partial class Index
    {
        [Inject]
        public ChainService ChainService { get; set; } = default!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        protected override async Task OnInitializedAsync()
        {
            App.MainViewModel.Projects = await ChainService.GetProjects();
            App.MainViewModel.Funders = await ChainService.GetFunders();

            await base.OnInitializedAsync();
        }

        public void GoToCreate()
        {
            NavigationManager.NavigateTo("create");
        }

    }
}
