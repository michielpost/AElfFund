
using CommunityToolkit.Mvvm.ComponentModel;

namespace AelfFund.Web.Models
{
    [ObservableObject]
    [ObservableRecipient]
    public partial class UserViewModel
    {
        [ObservableProperty]
        [NotifyPropertyChangedRecipients] 
        private bool hasExtension;

        [ObservableProperty]
        [NotifyPropertyChangedRecipients]
        private bool isConnected;

        [ObservableProperty]
        [NotifyPropertyChangedRecipients]
        private string? address;
       
    }
}
