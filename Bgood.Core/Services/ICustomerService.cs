using BgoodAPI.Entities;
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
        void AddCustomer(Customer newCust);
        Customer EditCustomer(int id, Customer updateCust);
        public void DeleteCustomer(int custID);

    }
}
