using AelfFund.Web.Services;
using Microsoft.AspNetCore.Components;

namespace AelfFund.Web.Pages
{
    public partial class Create
    {
        [Inject]
        public ChainService ChainService { get; set; } = default!;

        public async Task Test()
        {
            await ChainService.TestAsync();
        }

    }
}
