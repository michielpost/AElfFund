using AelfFund.Web.Models;
using AelfFund.Web.Services;
using Microsoft.AspNetCore.Components;

namespace AelfFund.Web.Pages
{
    public partial class Details
    {
        [Inject]
        public ChainService ChainService { get; set; } = default!;

        [Parameter]
        public string? Id { get; set; }

        public ProjectModel? Project { get; set; }

        public decimal Fund { get; set; }

        private int Index = -1; //default value cannot be 0 -> first selectedindex is 0.
        double[] data = { 30, 70 };
        string[] labels = { "Funded", "Needed" };



        public async Task FundProject()
        {
            await ChainService.TestAsync();
        }

        protected override async Task OnParametersSetAsync()
        {
            if (!string.IsNullOrEmpty(Id))
            {
                Project = await ChainService.GetProject(Id);
            }

            await base.OnParametersSetAsync();
        }

    }
}
