using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ACT_VALDEZ.Discount
{
    public class NoDiscountStrategy : IDiscountStrategy
    {
        public string Name => "None";

        public decimal Apply(decimal subtotal) => subtotal;
    }
}
