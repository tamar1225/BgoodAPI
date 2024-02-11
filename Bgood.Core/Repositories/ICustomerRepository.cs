using BgoodAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgood.Service
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetList();
        void Add(Customer newCustomer);
       void EditCustomer(int index, Customer updateCust);
        public void Delete(int index);
    }
}
