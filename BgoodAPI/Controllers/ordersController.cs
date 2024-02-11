using Bgood.Core.Services;
using BgoodAPI.Entities;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BgoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ordersController : ControllerBase
    {
       private readonly IOrderService _orders;
        public ordersController(IOrderService orderService)
        {
            _orders = orderService;
        }

        // GET: api/<ordersController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _orders.GetAll();
        }

        //- - - - - - להחזיר אקשיין ריזולט או הזמנה? ככה זה בלי הבדיקות
        // GET api/<ordersController>/5
        [HttpGet("{ordNum}")]
        public Order Get(int ordNum)
        {
           return _orders.GetByID(ordNum);          
        }
        

        //POST api/<ordersController>
        [HttpPost]
        public void Post([FromBody] Order newOrder)
        {
            _orders.AddOrder(newOrder);
        }

        // PUT api/<ordersController>/5
        [HttpPut("{ordNum}")]
        public Order Put(int ordNum ,[FromBody] string newStatus)
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
