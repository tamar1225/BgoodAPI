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
        /*

        // POST api/<ordersController>
        [HttpPost]
        public void Post([FromBody] Order newOrder)
        {
            orders.Add(newOrder);
        }

        / PUT api/<ordersController>/5
        [HttpPut("{ordNum}")]
        public ActionResult Put(int ordNum ,[FromBody] string newStatus)
        {
            int index = orders.FindIndex((o) => o.orderNum == ordNum);
            if (index != -1)
            {
                orders[index].status = newStatus;
                return Ok(orders[index]);
            }
            return NotFound();

        }

        // DELETE api/<ordersController>/5
        [HttpDelete("{ordNum}")]
        public ActionResult Delete(int ordNum)
        {
            int index = orders.FindIndex((o) => o.orderNum == ordNum);
            if (index != -1)
            {
                orders.RemoveAt(index);
                return Ok();
            }

            return NotFound();
        }*/
    }
    }
