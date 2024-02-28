namespace Bgood.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int orderNum { get; set; }
        public DateTime orderDate { get; set; }  
        public int customerID { get; set; }
        public Customer customer { get; set; }
        public double totalPrice { get; set; }
        public List<Product> products { get; set; }//לשאול מה לעשות עם ענין הכמות צריך לשים
                                                   //שדה נוסף בטבלה המקשרת
                                                   //?
        public string status { get; set; }
    }
}
