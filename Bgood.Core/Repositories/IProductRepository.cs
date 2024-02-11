using BgoodAPI.Entities;
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
        public void Add(Product newProd);
        public void UpdateProduct(int index, double newPrice);
        public void Delete(int index);

    }
}
