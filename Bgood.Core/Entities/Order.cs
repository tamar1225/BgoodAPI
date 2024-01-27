namespace BgoodAPI.Entities
{
    public class Order
    {
        public int orderNum { get; set; }
        public DateOnly orderDate { get; set; }
        public Customer customer { get; set; }
        public double totalPrice { get; set; }
        public List<Product> products { get; set; }
        public string status { get; set;}
    }
}
