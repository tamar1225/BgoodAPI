using Bgood.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace Bgood.Core.Services
{
    public interface IOrderService
    {
        List<Order> GetAll();
        Order GetByID(int ordNum);
        Task AddOrderAsync(Order newoOder);
        Task<Order> UpdateOrderAsync(int ordNum, string newStatus);
        Task DeleteOrderAsync(int ordNum);
    }
}
