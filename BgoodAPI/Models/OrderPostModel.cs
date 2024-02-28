using Bgood.Core.Entities;

namespace BgoodAPI.Models
{
    public class OrderPostModel
    {
        public int orderNum { get; set; }
        public DateTime orderDate { get; set; }
        public int customerID { get; set; }
        public double totalPrice { get; set; }
        public string status { get; set; }
    }
}
