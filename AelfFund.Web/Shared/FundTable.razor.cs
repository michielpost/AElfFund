using AelfFund.Web.Models;
using AelfFund.Web.Services;
using Microsoft.AspNetCore.Components;

namespace AelfFund.Web.Shared
{
    public partial class FundTable
    {
        [Parameter]
        public List<Funder> Funders { get; set; } = new List<Funder>();

        [Inject]
        public ChainService ChainService { get; set; } = default!;

        public string? CurrentAddress { get; set; }

        public async Task Cancel(string project, decimal amount)
        {
            await ChainService.CancelFunding(project, amount);
        }

        protected override async Task OnInitializedAsync()
        {
           CurrentAddress = await ChainService.GetAddressAsync();
        }
    }
}
