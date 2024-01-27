using BgoodAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgood.Core.Repositories
{
    public interface IOrderRepository
    {
        List<Order> GetList();

    }
}
