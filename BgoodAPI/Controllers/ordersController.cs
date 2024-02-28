using Bgood.Core.Services;
using Bgood.Core.Entities;
using BgoodAPI.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Bgood.Core.DTOs;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BgoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ordersController : ControllerBase
    {
        private readonly IOrderService _orders;
        private readonly IMapper _mapper;

        public ordersController(IOrderService orderService, IMapper mapper)
        {
            _orders = orderService;
            _mapper = mapper;
        }

        // GET: api/<ordersController>
        [HttpGet]
        public IEnumerable<OrderDTO> Get()
        {
            var list = _orders.GetAll();
            return _mapper.Map<IEnumerable<OrderDTO>>(list);
        }

        //- - - - - - להחזיר אקשיין ריזולט או הזמנה? ככה זה בלי הבדיקות
        // GET api/<ordersController>/5
        [HttpGet("{ordNum}")]
        public OrderDTO Get(int ordNum)
        {
            var order = _orders.GetByID(ordNum);
            return _mapper.Map<OrderDTO>(order);
        }


        //POST api/<ordersController>
        [HttpPost]
        public void Post([FromBody] OrderPostModel newOrder)
        {
            var orderToAdd = new Order()
            {
                status = newOrder.status,
                totalPrice = newOrder.totalPrice,
                customerID = newOrder.customerID,
                orderDate = newOrder.orderDate,
                orderNum = newOrder.orderNum
            };
            _orders.AddOrder(orderToAdd);
        }

        // PUT api/<ordersController>/5
        [HttpPut("{ordNum}")]
        public Order Put(int ordNum, [FromBody] string newStatus)
        {

            return _orders.UpdateOrder(ordNum, newStatus);
        }

        // DELETE api/<ordersController>/5
        [HttpDelete("{ordNum}")]
        public void Delete(int ordNum)
        {
            _orders.DeleteOrder(ordNum);
        }
    }
}
