using BgoodAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgood.Data
{
    public class DataContext
    {
        public List<Order> Orders { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Product> Products { get; set; }
        public DataContext()
        {
            Orders = new List<Order>
            {
            };
            Customers = new List<Customer> { };
            Products = new List<Product>
            {
                new Product
                {
                    ProdID = 101, ProductName = "shirt",Price = 150, Category= "women"
                }
            };
        }
    }
}
