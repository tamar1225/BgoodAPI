using Bgood.Core.Repositories;
using Bgood.Core.Entities;

/*using BgoodAPI.Entities;
*/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Bgood.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;
        public ProductRepository(DataContext datacontext)
        {
            _context = datacontext;
        }
        public IEnumerable<Product> GetList()
        {
            return _context.Products.Include(p=>p.Orders);
        }

        public void Add(Product newProd)
        {
            _context.Products.Add(newProd);
            _context.SaveChanges();
        }

        public void UpdateProduct(int index, double newPrice)
        {
            _context.Products.ToList()[index].Price = newPrice;
            _context.SaveChanges();
        }

        public void Delete(int index)
        {
            _context.Remove(_context.Products.ToList()[index]);
            _context.SaveChanges();
        }

    }
}
