using Bgood.Service;
using BgoodAPI.Entities;
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
            return _context.Customers.ToList();
        }
        public void Add(Customer newCustomer)
        {
            _context.Customers.Add(newCustomer);
            _context.SaveChanges();
        }
        public void EditCustomer(int index, Customer updateCust)
        {
            //למה אי אפשר      :
            // _context.Customers.ToList()[index] = updateCust;  ????
            _context.Customers.ToList()[index].Address = updateCust.Address;
            _context.Customers.ToList()[index].Name = updateCust.Name;
            _context.Customers.ToList()[index].IsMember = updateCust.IsMember;
            _context.SaveChanges();
        }

        public void Delete(int index)
        {
            _context.Customers.ToList()[index].IsMember=false;
            _context.SaveChanges();
        }
    }
}
