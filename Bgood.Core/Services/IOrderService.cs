using BgoodAPI.Entities;
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
    }
}
