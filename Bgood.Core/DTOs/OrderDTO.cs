using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgood.Core.DTOs
{
    public class OrderDTO    {
        public int orderNum { get; set; }
        public DateTime orderDate { get; set; }
        public int customerID { get; set; }
        public double totalPrice { get; set; }
        public string status { get; set; }
    }
}
