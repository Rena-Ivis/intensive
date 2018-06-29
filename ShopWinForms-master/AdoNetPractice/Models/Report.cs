namespace AdoNetPractice.Models
{
    public class Report
    {
        public int OrderId { get; set; }
        public string ClientName { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
    }
}
