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
        public List<Funder>? Funders { get; set; }

        public decimal Fund { get; set; }

        private int Index = -1; //default value cannot be 0 -> first selectedindex is 0.
        double[] data = { 0,0 };
        string[] labels = { "Funded", "Needed" };

        public async Task ConnectWallet()
        {
            await ChainService.ConnectOrInstallWalletAsync();
            StateHasChanged();
        }

        public async Task FundProject()
        {
            if(Project != null)
            {
                await ChainService.FundProject(Project.Id, "YOU", Fund);

                await ReloadData();

                StateHasChanged();
            }
        }

        protected override async Task OnParametersSetAsync()
        {
            if (!string.IsNullOrEmpty(Id))
            {
                await ReloadData();
            }

            await base.OnParametersSetAsync();
        }

        private async Task ReloadData()
        {
            Project = await ChainService.GetProject(Id);

            if (Project != null)
            {
                data[0] = Convert.ToDouble(Project.FundCurrent);
                data[1] = Convert.ToDouble(Project.FundNeed);

                labels[0] = $"Donated ({Project.FundCurrent} ELF)";
                labels[1] = $"Needed ({Project.FundNeed} ELF)";

                Funders = await ChainService.GetFundersForProject(Id);
            }
        }
    }
}
