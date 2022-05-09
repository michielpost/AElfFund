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

        public async Task Cancel(string project, decimal amount)
        {
            await ChainService.CancelFunding(project, amount);
        }
    }
}
