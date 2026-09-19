using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ACT_VALDEZ.Discount
{
    public interface IDiscountStrategy
    {
        string Name { get; }
        decimal Apply(decimal subtotal);
    }
}
