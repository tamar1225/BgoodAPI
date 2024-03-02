using Bgood.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgood.Core.Services
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetByID(int prodId);
        Task AddProductAsync(Product newProd);
        Task<Product> UpdateProductAsync(int prodId, double newPrice);
        Task DeleteProductAsync(int prodId);
    }
}
