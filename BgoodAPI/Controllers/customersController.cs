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

       // GET api/<productsController>/5
        [HttpGet("{id}")]
        public Customer Get(int ordNum)
        {
            return _customers.GetByID(ordNum);

        } 

        // POST api/<priductsController>
        [HttpPost]
        public void Post([FromBody] Customer newCustomer)
        {        
            _customers.AddCustomer(newCustomer);
        }

        // PUT api/<productsController>/5
        [HttpPut("{id}")]
        public Customer Put(int id, [FromBody] Customer updateCust)
        {
           return _customers.EditCustomer(id, updateCust);

        }

        // PUT api/<productsController>/5
        [HttpPut("{id}/status")]
        public void Delete(int id)
        {
            _customers.DeleteCustomer(id);
        }
    }
}
