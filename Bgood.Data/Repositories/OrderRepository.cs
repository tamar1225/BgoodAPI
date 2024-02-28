using Bgood.Core.Repositories;
using Bgood.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgood.Data.Repositories
{
    public class OrderRepository:IOrderRepository
    {
        private readonly DataContext _datacontext;
        public OrderRepository(DataContext data)
        {
            _datacontext = data;
        }
        public IEnumerable<Order> GetList()
        {
            //מחזיר ללא כל נתוני הלקוח, יהיה רק את הID שלו
            return _datacontext.Orders;//.Include(o => o.products).Include(o => o.customer);
        }
        public void Add(Order order) 
        {
         _datacontext.Orders.Add(order);
         _datacontext.SaveChanges();
        }
        public void UpdateOrder(int index, String newStatus) 
        {
            _datacontext.Orders.ToList()[index].status = newStatus;
            _datacontext.SaveChanges();
        }
        public void Delete(int index) 
        {
            _datacontext.Remove(_datacontext.Orders.ToList()[index]);
            //_datacontext.Orders.ToList().RemoveAt(index);
            _datacontext.SaveChanges();
        }
    }
}
