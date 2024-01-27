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
            
            Customers = new List<Customer>{
             new Customer {ID=325, Name="TamarMalik", Address="tzvi 17", IsMember=true},
             new Customer {ID=326, Name="MorL", Address="sigim 1", IsMember=true},
             new Customer {ID=327, Name="YamR", Address="dan 20", IsMember=false},

    };
            Products = new List<Product>
            {
             new Product { ProdID = 101, ProductName = "shirt",Price = 150, Category= "women"},
             new Product { ProdID = 102, ProductName = "dress",Price = 300, Category= "woman"},
             new Product { ProdID = 103, ProductName = "coat",Price = 250, Category= "children"}

            };
            Orders = new List<Order>
            {new Order {orderNum=1000, orderDate=DateOnly.FromDateTime(DateTime.Now),customer=Customers[1],products=new List<Product>{Products[0],Products[1]},totalPrice=450.0,status="send" },
             new Order {orderNum=1010, orderDate=DateOnly.FromDateTime(DateTime.Now),customer=Customers[0],products=new List<Product>{Products[2]},totalPrice=250.0,status="recieved" }
            };
        }
    }
}
