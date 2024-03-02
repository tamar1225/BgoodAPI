using Bgood.Core.Entities;
using Bgood.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgood.Data.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly DataContext _context;
        public CustomerRepository(DataContext context) {
            _context = context;
        }
        public IEnumerable<Customer> GetList()
        {
            return _context.Customers.Include(c=>c.Orders);
        }
        public async Task AddAsync(Customer newCustomer)
        {
            _context.Customers.Add(newCustomer);
            await _context.SaveChangesAsync();
        }
        public async Task EditCustomerAsync(int index, Customer updateCust)
        {
            //למה אי אפשר      :
            // _context.Customers.ToList()[index] = updateCust;  ????
            _context.Customers.ToList()[index].Address = updateCust.Address;
            _context.Customers.ToList()[index].Name = updateCust.Name;
            _context.Customers.ToList()[index].IsMember = updateCust.IsMember;
           await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int index)
        {
            _context.Customers.ToList()[index].IsMember=false;
           await _context.SaveChangesAsync();
        }

      
       
    }
}
