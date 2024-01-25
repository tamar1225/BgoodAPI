using Bgood.Core.Repositories;

using BgoodAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgood.Service
{
    public class ProductService
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
    }
}
