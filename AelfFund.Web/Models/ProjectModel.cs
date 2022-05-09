namespace AelfFund.Web.Models
{
    public class ProjectModel
    {
        public string Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;

        public long FundGoal { get; set; }
        public long FundCurrent { get; set; }
        public DateTimeOffset EndDate { get; set; }

        public bool IsActive { get; set; } = true;


    }
}
