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

        public async Task GetBalance()
        {
            var balance = await ChainService.GetBalanceAsync();
            Console.WriteLine($"{balance?.Owner} | {balance?.ELFBalance} | {balance?.Symbol}");
        }

        public async Task UseFaucet()
        {
            var txId = await ChainService.UseFaucetAsync();
            Console.WriteLine($"TxId: {txId}");
        }

        public async Task GetTx()
        {
            var result = await ChainService.GetTxStatus("da9e53ed41db282668b8cee1cc2e81b54eccfe96c84f4aa94e7401c5a5f52760");
            Console.WriteLine(result.Status);

            //ChainService.GetTxStatus("a504439aa2992b2e81674698326875478b3c4c024eb5be9d0b06e811a1ec8b4a");
        }

        protected override async Task OnInitializedAsync()
        {
            App.MainViewModel.Projects = await ChainService.GetProjects();
            App.MainViewModel.Funders = await ChainService.GetFunders();

            await base.OnInitializedAsync();
        }

        public void GoToCreate()
        {
            NavigationManager.NavigateTo("/create");
        }

    }
}
