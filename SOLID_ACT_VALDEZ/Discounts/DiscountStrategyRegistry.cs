using SOLID_ACT_VALDEZ.Discount;
using System.Collections.Generic;
using System.Linq;

namespace SOLID_ACT_VALDEZ
{
   
    public class DiscountStrategyRegistry
    {
        private readonly List<IDiscountStrategy> strategies;

        public DiscountStrategyRegistry(IEnumerable<IDiscountStrategy> strategies)
        {
            this.strategies = strategies.ToList();
        }

        public IDiscountStrategy GetByName(string name)
        {
            var match = strategies.FirstOrDefault(s => s.Name == name);
            return match ?? new NoDiscountStrategy();
        }
    }
}
