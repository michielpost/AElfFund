namespace AelfFund.Web.Models
{
    public class CreateProjectModel
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;

        public decimal FundGoal { get; set; }
        public DateTimeOffset EndDate { get; set; }



    }
}
