using SOLID_ACT_VALDEZ.Discount;
using System.Collections.Generic;
using System.Linq;

namespace SOLID_ACT_VALDEZ.Discount
{

    public class DiscountStrategyRegistry
    {
        private readonly Dictionary<string, IDiscountStrategy> strategies;

        public DiscountStrategyRegistry(IEnumerable<IDiscountStrategy> strategies)
        {
            this.strategies = strategies.ToDictionary(s => s.Name);
        }

        public IDiscountStrategy GetStrategy(string discountType)
        {
            return strategies.TryGetValue(discountType, out var strategy)
                ? strategy
                : strategies["None"];
        }
    }
}
