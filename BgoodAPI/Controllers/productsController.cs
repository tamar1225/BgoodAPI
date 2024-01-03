﻿using BgoodAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BgoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productsController : ControllerBase
    {
        private static List<Product> products = new List<Product>{
         new Product {prodID=1, productName="Tshirt", Category="children", price=100},
         new Product {prodID=2, productName="shoes", Category="children", price=150},
         new Product {prodID=3, productName="coat", Category="children", price=250}
    };

        // GET: api/<prductsController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }

        // GET api/<productsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            foreach (var item in products)
            {
                if (item.prodID == id)
                    return Ok(item);
            }
            return NotFound();
        }

        // POST api/<priductsController>
        [HttpPost]
        public void Post([FromBody] Product newProd)
        {
            products.Add(newProd);
        }

        // PUT api/<productsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] double newPrice)
        {
            int index = products.FindIndex((p) => p.prodID == id);
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
            int index = products.FindIndex((p) => p.prodID == id);
            if (index != -1)
            {
                products.RemoveAt(index);
                return Ok();
            }
                
            return NotFound();
        }
    }
}