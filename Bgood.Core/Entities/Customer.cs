﻿namespace Bgood.Core.Entities
{
    public class Customer
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool IsMember { get; set; }  
        public List<Order> Orders { get; set; }


    }
}
