using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ACT_VALDEZ.Models
{
    public class OrderItem
    {
        public string Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public decimal LineTotal => Price * Quantity;
    }
}
