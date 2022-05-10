using AelfFund.Web.Models;

namespace AelfFund.Web
{
    public partial class App
    {
        public static MainViewModel MainViewModel { get; set; } = new();
        public static UserViewModel UserViewModel { get; set; } = new();
    }
}
