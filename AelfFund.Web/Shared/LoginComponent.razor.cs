﻿using AelfFund.Web.Services;
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
            await ChainService.RefreshViewModel();
        }

       

        public async Task Login()
        {
            await ChainService.ConnectOrInstallWalletAsync();
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