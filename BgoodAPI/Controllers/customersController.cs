using Bgood.Core.Services;
using Bgood.Core.Entities;
using BgoodAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AutoMapper;
using Bgood.Core.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BgoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class customerController : ControllerBase
    {
        private readonly ICustomerService _customers;
        private readonly IMapper _mapper;
        public customerController(ICustomerService customerService, IMapper mapper)
        {
            _customers = customerService;
            _mapper = mapper;
        }

        // GET: api/<prductsController>
        [HttpGet]
        public IEnumerable<CustomerDTO> Get()
        {
            var list= _customers.GetAll();
            var listDTO= _mapper.Map<IEnumerable<CustomerDTO>>(list);
            return listDTO;
        }

       // GET api/<productsController>/5
        [HttpGet("{id}")]
        public CustomerDTO Get(int ordNum)
        {
            var customer= _customers.GetByID(ordNum);
            return _mapper.Map<CustomerDTO>(customer);

        } 

        // POST api/<priductsController>
        [HttpPost]
        public void Post([FromBody] CustomerPostModel newCustomer)
        {        
            var customerToAdd = _mapper.Map<Customer>(newCustomer);
            _customers.AddCustomer(customerToAdd);
        }

        // PUT api/<productsController>/5
        [HttpPut("{id}")]
        public Customer Put(int id, [FromBody] CustomerPostModel updateCust)
        {
            var customerUpdate = new Customer() { Name = updateCust.Name, IsMember = updateCust.IsMember, Address = updateCust.Address };
            return _customers.EditCustomer(id, customerUpdate);

        }

        // PUT api/<productsController>/5
        [HttpPut("{id}/status")]
        public void Delete(int id)
        {
            _customers.DeleteCustomer(id);
        }
    }
}
