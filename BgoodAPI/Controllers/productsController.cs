using Bgood.Core.Services;
using Bgood.Service;
using BgoodAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BgoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/<prductsController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetAll();
        }

        // GET api/<productsController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _productService.GetByID(id);
        }

        // POST api/<priductsController>
        [HttpPost]
        public void Post([FromBody] Product newProd)
        {
            _productService.AddProduct(newProd);
        }

        // PUT api/<productsController>/5
        [HttpPut("{id}")]
        public Product Put(int id, [FromBody] double newPrice)
        {
            return _productService.UpdateProduct(id, newPrice);

        }

        // DELETE api/<productsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productService.DeleteProduct(id);
        }

    }
}
