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
            return _prodRepository.GetList();
        }
        public Product GetProduct(int id)
        {
            foreach (var item in _prodRepository.GetList())
            {
                if (item.ProdID == id)
                    return item;
            }
            return null;
        }
    }
}
