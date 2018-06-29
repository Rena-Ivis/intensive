namespace AdoNetPractice.Models
{
    public class Order
    {
        public int? Id { get; set; }
        public int ProductId { get; set; }
        public int ClientId { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return "#"+Id;
        }
    }
}