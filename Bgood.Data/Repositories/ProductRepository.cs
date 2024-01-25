using Bgood.Core.Repositories;
using BgoodAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgood.Data.Repositories
{   
    public class ProductRepository:IProductRepository
    {
        private readonly DataContext _context;
        public ProductRepository(DataContext context)
        {
            _context = context;
        }
        public List<Product> GetList()
        {
            return _context.Products;
        }
    }
}
