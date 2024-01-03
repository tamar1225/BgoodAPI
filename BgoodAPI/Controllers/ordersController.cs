using BgoodAPI.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BgoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ordersController : ControllerBase
    {
        // GET: api/<ordersController>
        private static List<Order> customers = new List<Order>{
         new Order {orderNum=325, Name="TamarMalik", Address="tzvi 17", IsMember=true},



    };

        // GET: api/<ordersController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return customers;
        }

        // GET api/<ordersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            foreach (var item in customers)
            {
                if (item.ID == id)
                    return Ok(item);
            }
            return NotFound();
        }

        // POST api/<ordersController>
        [HttpPost]
        public void Post([FromBody] Customer newCustomer)
        {
            newCustomer.IsMember = true;
            customers.Add(newCustomer);
        }

        // PUT api/<ordersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Customer updateCust)
        {
            int index = customers.FindIndex((c) => c.ID == id);
            if (index != -1)
            {
                customers[index] = updateCust;
                return Ok(customers[index]);
            }
            return NotFound();

        }

        // DELETE api/<ordersController>/5
        [HttpPut("{id}/status")]
        public ActionResult Delete(int id)
        {
            int index = customers.FindIndex((c) => c.ID == id);
            if (index != -1)
            {
                customers[index].IsMember = false;
                return Ok(customers[index]);
            }

            return NotFound();
        }
    }
    }
