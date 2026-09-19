using SOLID_ACT_VALDEZ.Discount;
using SOLID_ACT_VALDEZ.Models;
using SOLID_ACT_VALDEZ.Service;

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

        public decimal CalculateTotal(Order order, string discountType)
        {
            decimal total = order.Items.Sum(i => i.Price * i.Quantity);
            var strategy = discountRegistry.GetStrategy(discountType);
            return strategy.Apply(total);
        }
    }
}
