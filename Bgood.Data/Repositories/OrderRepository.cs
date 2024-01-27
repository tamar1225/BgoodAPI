using Bgood.Core.Repositories;
using BgoodAPI.Entities;
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
        public List<Order> GetList()
        {
            return _datacontext.Orders;
        }
    }
}
