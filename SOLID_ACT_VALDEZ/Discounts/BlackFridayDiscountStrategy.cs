using SOLID_ACT_VALDEZ.Discount;

namespace SOLID_ACT_VALDEZ
{
    public class BlackFridayDiscountStrategy : IDiscountStrategy
    {
        public string Name => "BlackFriday";

        public decimal Apply(decimal subtotal) => subtotal * 0.7m;
    }
}
