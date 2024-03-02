using Bgood.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgood.Core.Services
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetByID(int id);
        Task AddCustomerAsync(Customer newCust);
        Task<Customer> EditCustomerAsync(int id, Customer updateCust);
        public Task DeleteCustomerAsync(int custID);

    }
}
