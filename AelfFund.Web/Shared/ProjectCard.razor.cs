using AelfFund.Web.Models;
using Microsoft.AspNetCore.Components;

namespace AelfFund.Web.Shared
{
    public partial class ProjectCard
    {
        [Parameter]
        public ProjectModel? Project { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        public void GoToDetails()
        {
            NavigationManager.NavigateTo($"/project/{Project?.Id}");
        }
    }
}
