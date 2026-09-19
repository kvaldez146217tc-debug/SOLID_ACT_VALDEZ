 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ACT_VALDEZ.Discount
{
    public class SeniorDiscountStrategy : IDiscountStrategy
    {
        public string Name => "Senior";

        public decimal Apply(decimal subtotal) => subtotal * 0.85m;
    }
}
