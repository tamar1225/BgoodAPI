using BgoodAPI.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BgoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ordersController : ControllerBase
    {
        static Customer cust1 = new Customer { ID = 326, Name = "MorL", Address = "sigim 1", IsMember = true };
        static Customer cust2 = new Customer { ID = 325, Name = "TamarMalik", Address = "tzvi 17", IsMember = true };
        private static List<Order> orders = new List<Order>{
         new Order {orderNum=1010, customer=cust1, orderDate=new DateOnly(2023, 12, 31), status="recived", totalPrice=400},
         new Order {orderNum=1022, customer=cust2, orderDate=new DateOnly(2023, 12, 26), status="sent", totalPrice=330},
    };

        // GET: api/<ordersController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return orders;
        }

        // GET api/<ordersController>/5
        [HttpGet("{ordNum}")]
        public ActionResult Get(int ordNum)
        {
            foreach (var item in orders)
            {
                if (item.orderNum == ordNum)
                    return Ok(item);
            }
            return NotFound();
        }

        // POST api/<ordersController>
        [HttpPost]
        public void Post([FromBody] Order newOrder)
        {
            orders.Add(newOrder);
        }

        // PUT api/<ordersController>/5
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
        }
    }
    }
