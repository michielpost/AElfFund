namespace AelfFund.Web.Models
{
    public class Funder
    {
        public string Address { get; set; } = default!;
        public string ProjectId { get; set; } = default!;
        public string? ProjectName { get; set; }
        public string TxId { get; set; } = default!;
        public decimal Amount { get; set; }
    }
}
