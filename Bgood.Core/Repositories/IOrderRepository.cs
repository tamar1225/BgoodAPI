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
        Task AddAsync(Order order);
        Task UpdateOrderAsync(int index, string newStatus);
        Task DeleteAsync(int index);
    }
}
