namespace Bgood.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int ProdID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public List<Order> Orders { get; set; }

    }
}