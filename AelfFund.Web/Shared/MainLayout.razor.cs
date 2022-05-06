using Microsoft.AspNetCore.Components;

namespace AelfFund.Web.Shared
{
    public partial class MainLayout
    {

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        public void Logout()
        {
            NavigationManager.NavigateTo("/");
        }
    }
}
