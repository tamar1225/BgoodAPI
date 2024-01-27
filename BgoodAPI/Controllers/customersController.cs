using Bgood.Core.Services;
using BgoodAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BgoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class customerController : ControllerBase
    {
        private readonly ICustomerService _customers;
        public customerController(ICustomerService customerService)
        {
            _customers = customerService;
        }

        // GET: api/<prductsController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customers.GetAll();
        }

       /* // GET api/<productsController>/5
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

        // POST api/<priductsController>
        [HttpPost]
        public void Post([FromBody] Customer newCustomer)
        {
            newCustomer.IsMember= true;
            customers.Add(newCustomer);
        }

        // PUT api/<productsController>/5
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

        // PUT api/<productsController>/5
        [HttpPut("{id}/status")]
        public ActionResult Delete(int id)
        {
            int index = customers.FindIndex((c) => c.ID == id);
            if (index != -1)
            {
                customers[index].IsMember=false;
                return Ok(customers[index]);
            }

            return NotFound();
        }*/
    }
}
