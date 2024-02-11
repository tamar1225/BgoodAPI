namespace BgoodAPI.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int orderNum { get; set; }
        public DateTime orderDate { get; set; }
        public Customer customer { get; set; }
        public double totalPrice { get; set; }
        public Product product { get; set; }
        public string status { get; set;}
    }
}
