using Bgood.Core.Repositories;
using Bgood.Core.Services;
using Bgood.Core.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgood.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public List<Customer> GetAll()
        {
            return _customerRepository.GetList().ToList();
        }
        public Customer GetByID(int id)
        {
            Customer customer = _customerRepository.GetList().ToList().Find(c => c.Id == id);
            return customer;
        }
        public void AddCustomer(Customer newCust)
        {
            int index = GetAll().FindIndex((c) => c.Id == newCust.Id);
            if (index == -1)
            {
                newCust.IsMember = false;
                _customerRepository.Add(newCust);
            }
            Console.WriteLine("customer is already exists");
        }

        public Customer EditCustomer(int id, Customer updateCust)
        {
            updateCust.Id=id;
            int index = GetAll().FindIndex((c) => c.Id == updateCust.Id);
            if (index == -1)
            {
                return null;
            }
            _customerRepository.EditCustomer(index, updateCust);
            return GetAll()[index];
        }
        public void DeleteCustomer(int custID)
        {
            int index = GetAll().FindIndex((c) => c.Id == custID);
            if (index != -1)
            {
                _customerRepository.Delete(index);
            }
        }
    }
}
