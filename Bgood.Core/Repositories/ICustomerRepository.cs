using Bgood.Core.Entities;
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
        Task AddAsync(Customer newCustomer);
       Task EditCustomerAsync(int index, Customer updateCust);
        public Task DeleteAsync(int index);
    }
}
