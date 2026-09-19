using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ACT_VALDEZ.Discount
{
    public class StudentDiscountStrategy : IDiscountStrategy
    {
        public string Name => "Student";

        public decimal Apply(decimal subtotal) => subtotal * 0.9m;
    }
}
