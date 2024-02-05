using Bgood.Core.Repositories;
using Bgood.Core.Services;
using BgoodAPI.Entities;
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
            return _orderRepository.GetList();
        }

        /* public ActionResult GetByID(int ordNum)
         {
             Order order = _orderRepository.GetList().Find((o => o.orderNum == ordNum));
             if (order != null)
             {
                 return Ok(order);
             }
             return NotFound();
         }*/
        public Order GetByID(int ordNum)
        {
            Order order = _orderRepository.GetList().Find((o => o.orderNum == ordNum));
            return order;
        }
    }
}
