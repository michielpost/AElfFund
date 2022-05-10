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


        protected override async Task OnInitializedAsync()
        {
            await RefreshViewModel();

        }

        private async Task RefreshViewModel()
        {
            App.UserViewModel.HasExtension = await ChainService.HasNightElfAsync();
            App.UserViewModel.IsConnected = await ChainService.IsConnectedAsync();

            if (App.UserViewModel.IsConnected)
                App.UserViewModel.Address = await ChainService.GetAddressAsync();
        }

        public async Task Login()
        {
            await ChainService.LoginAsync();
            await RefreshViewModel();
        }

        public async Task Logout()
        {
            await ChainService.LogoutAsync();
            await RefreshViewModel();
        }

        public void InstallDialog()
        {
            DialogService.Show<InstallExtensionDialog>("Install NightElf");
        }

    }
}
