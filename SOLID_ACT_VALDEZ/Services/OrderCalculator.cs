using SOLID_ACT_VALDEZ.Discount;
using SOLID_ACT_VALDEZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ACT_VALDEZ.Services
{
    public class OrderCalculator : IOrderCalculator
    {
        private readonly DiscountStrategyRegistry discountRegistry;

        public OrderCalculator(DiscountStrategyRegistry discountRegistry)
        {
            this.discountRegistry = discountRegistry;
        }

        public decimal CalculateTotal(Order order, string discountName)
        {
            decimal subtotal = order.Items.Sum(item => item.LineTotal);
            IDiscountStrategy strategy = discountRegistry.GetByName(discountName);
            return strategy.Apply(subtotal);
        }
    }
}
