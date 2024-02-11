using BgoodAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bgood.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//פונקציה שנמצאת בDBContext 
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=my_db"); //אומר לו באיזה מסד נתונים להשתמש
        }

    }
}
