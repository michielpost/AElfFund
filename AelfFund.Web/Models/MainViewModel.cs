namespace AelfFund.Web.Models
{
    public class MainViewModel
    {

        public bool IsLoading { get; set; }

        public List<ProjectModel> Projects { get; set; } = new List<ProjectModel>();
    }
}
