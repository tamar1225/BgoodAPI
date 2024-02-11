using Bgood.Core.Repositories;
using Bgood.Core.Services;
using BgoodAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Bgood.Service
{
    public class ProductService:IProductService
    {
        private readonly IProductRepository _prodRepository;
        public ProductService(IProductRepository productRepository)
        {
            _prodRepository=productRepository;
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

        public void AddProduct(Product newProd)
        {
            _prodRepository.Add(newProd);
        }
        public Product UpdateProduct(int prodId, double newPrice)
        {
            int index = GetAll().FindIndex((p) => p.ProdID == prodId);
            if (index == -1)
            {
                return null;
            }
            _prodRepository.UpdateProduct(index, newPrice);
            return GetAll()[index];
        }
        public void DeleteProduct(int prodId)
        {
            int index = GetAll().FindIndex((p) => p.ProdID == prodId);
            if (index != -1)
            {
                _prodRepository.Delete(index);
            }
        }

    }
}
