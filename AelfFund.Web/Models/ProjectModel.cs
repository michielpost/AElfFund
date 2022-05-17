namespace AelfFund.Web.Models
{
    public class ProjectModel
    {
        public string Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;

        public decimal FundGoal { get; set; }
        public decimal FundCurrent { get; set; }
        public decimal FundNeed => FundCurrent >= FundGoal ? 0 : FundGoal - FundCurrent;

        public DateTimeOffset EndDate { get; set; }

        public bool IsActive { get; set; } = true;


    }
}
