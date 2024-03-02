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
        public async Task AddAsync(Order order) 
        {
         _datacontext.Orders.Add(order);
         await _datacontext.SaveChangesAsync();
        }
        public async Task UpdateOrderAsync(int index, String newStatus) 
        {
            _datacontext.Orders.ToList()[index].status = newStatus;
           await _datacontext.SaveChangesAsync();
        }
        public async Task DeleteAsync(int index) 
        {
            _datacontext.Remove(_datacontext.Orders.ToList()[index]);
            //_datacontext.Orders.ToList().RemoveAt(index);
           await _datacontext.SaveChangesAsync();
        }
    }
}
