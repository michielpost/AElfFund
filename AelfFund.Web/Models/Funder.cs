namespace AelfFund.Web.Models
{
    public class Funder
    {
        public string Address { get; set; } = default!;
        public string Project { get; set; } = default!;
        public string TxId { get; set; } = default!;
        public decimal Amount { get; set; }
    }
}
