using BgoodAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgood.Core.Services
{
    public interface IOrderService
    {
        List<Order> GetAll();
    }
}
