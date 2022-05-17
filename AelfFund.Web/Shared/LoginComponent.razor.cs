using AelfFund.Web.Services;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace AelfFund.Web.Shared
{
    public partial class LoginComponent
    {
        [Inject]
        public ChainService ChainService { get; set; } = default!;

        [Inject]
        public IDialogService DialogService { get; set; } = default!;

        public string ButtonText { get; set; } = "Connect Wallet";


        protected override async Task OnInitializedAsync()
        {
            await ChainService.RefreshViewModel();
        }

       

        public async Task Login()
        {
            ButtonText = "Connecting...";
            await ChainService.ConnectOrInstallWalletAsync();
            ButtonText = "Connect Wallet";
            StateHasChanged();
        }

        public async Task Logout()
        {
            await ChainService.LogoutAsync();
            StateHasChanged();
        }

        public void InstallDialog()
        {
            DialogService.Show<InstallExtensionDialog>("Install NightElf");
        }

    }
}
