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

        public async Task AddAsync(Product newProd)
        {
            _context.Products.Add(newProd);
           await _context.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(int index, double newPrice)
        {
            _context.Products.ToList()[index].Price = newPrice;
           await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int index)
        {
            _context.Remove(_context.Products.ToList()[index]);
          await  _context.SaveChangesAsync();
        }

    }
}
