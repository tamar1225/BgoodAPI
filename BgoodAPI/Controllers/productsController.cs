﻿using Bgood.Core.Services;
using Bgood.Service;
using Bgood.Core.Entities;
using BgoodAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bgood.Core.DTOs;
using AutoMapper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BgoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        // GET: api/<prductsController>
        [HttpGet]
        public IEnumerable<ProductDTO> Get()
        {
            var list=_productService.GetAll();
            return _mapper.Map<IEnumerable<ProductDTO>>(list);
        }

        // GET api/<productsController>/5
        [HttpGet("{id}")]
        public ProductDTO Get(int id)
        {
            var product=_productService.GetByID(id);
            return _mapper.Map<ProductDTO>(product);

        }

        // POST api/<priductsController>
        [HttpPost]
        public void Post([FromBody] ProductPostModel newProd)
        {
            var productToAdd=new Product() { Price=newProd.Price, Category=newProd.Category, ProductName=newProd.ProductName };
            _productService.AddProduct(productToAdd);
        }

        // PUT api/<productsController>/5
        [HttpPut("{id}")]
        public Product Put(int id, [FromBody] double newPrice)//  ??יש ענין לשנות
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
