using Bgood.Core.Repositories;
using Bgood.Core.Services;
using Bgood.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Bgood.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _prodRepository;
        public ProductService(IProductRepository productRepository)
        {
            _prodRepository = productRepository;
        }

        public List<Product> GetAll()
        {
            return _prodRepository.GetList().ToList();
        }
        public Product GetByID(int prodId)
        {
            Product product = GetAll().Find(p => p.ProdID == prodId);
            return product;
        }

        public async Task AddProductAsync(Product newProd)
        {
            await _prodRepository.AddAsync(newProd);
        }
        public async Task<Product> UpdateProductAsync(int prodId, double newPrice)
        {
            int index = GetAll().FindIndex((p) => p.ProdID == prodId);
            if (index == -1)
            {
                return null;
            }
            await _prodRepository.UpdateProductAsync(index, newPrice);
            return GetAll()[index];
        }
        public async Task DeleteProductAsync(int prodId)
        {
            int index = GetAll().FindIndex((p) => p.ProdID == prodId);
            if (index != -1)
            {
                await _prodRepository.DeleteAsync(index);
            }
        }

    }
}
