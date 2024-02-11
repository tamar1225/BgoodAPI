using BgoodAPI.Entities;
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
        void AddProduct(Product newProd);
        Product UpdateProduct(int prodId, double newPrice);
        void DeleteProduct(int prodId);
    }
}
