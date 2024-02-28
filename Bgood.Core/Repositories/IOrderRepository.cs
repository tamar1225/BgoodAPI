using Bgood.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgood.Core.Repositories
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetList();
        void Add(Order order);
        void UpdateOrder(int index, string newStatus);
        void Delete(int index);
    }
}
