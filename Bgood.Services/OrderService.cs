using Bgood.Core.Repositories;
using Bgood.Core.Services;
using Bgood.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Bgood.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public List<Order> GetAll()
        {
            return _orderRepository.GetList().ToList();
        }

        public Order GetByID(int ordNum)
        {
                                                    //IENUMREABLEלשנות שיתאים ל
            Order order = GetAll().Find(o => o.orderNum == ordNum);
            return order;
        }
        public void AddOrder(Order order) {
            _orderRepository.Add(order);
        }
        public Order UpdateOrder(int ordNum, string newStatus)
        {
            int index = GetAll().FindIndex((o) => o.orderNum == ordNum);
            if (index == -1)
            {       
                return null;
            }
             _orderRepository.UpdateOrder(index, newStatus);
            return GetAll()[index];
        }
        public void DeleteOrder(int ordNum)
        {
            int index = GetAll().FindIndex((o) => o.orderNum == ordNum);
            if (index != -1)
            {
                _orderRepository.Delete(index);
            }
        }
            
    }
}
