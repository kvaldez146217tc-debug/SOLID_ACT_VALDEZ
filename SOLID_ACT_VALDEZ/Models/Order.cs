using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ACT_VALDEZ.Models
{
    public class Order
    {
        public string CustomerEmail { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public decimal Total { get; set; }
    }
}
