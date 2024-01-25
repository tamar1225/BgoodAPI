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
        private readonly ProductService _productService;
        
        public ProductsController(ProductService productService)
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
            /*  foreach (var item in _productService.GetAll())
              {
                  if (item.ProdID == id)
                      return Ok(item);
              }
              return NotFound();*/
            return _productService.GetProduct(id); 
        }

     /*     // POST api/<priductsController>
        [HttpPost]
        public void Post([FromBody] Product newProd)
        {
            products.Add(newProd);
        }

        // PUT api/<productsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] double newPrice)
        {
            int index = products.FindIndex((p) => p.ProdID == id);
            if (index != -1)
            {
                products[index].price = newPrice;
                return Ok(products[index]);
            }
            return NotFound();

        }

        // DELETE api/<productsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            int index = products.FindIndex((p) => p.ProdID == id);
            if (index != -1)
            {
                products.RemoveAt(index);
                return Ok();
            }
            return NotFound();
        }
     */
    }
}
