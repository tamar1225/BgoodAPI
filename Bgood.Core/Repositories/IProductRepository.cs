using Bgood.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bgood.Core.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetList();
        public Task AddAsync(Product newProd);
        public Task UpdateProductAsync(int index, double newPrice);
        public Task DeleteAsync(int index);

    }
}
