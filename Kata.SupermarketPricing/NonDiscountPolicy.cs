using System;

namespace Kata.SupermarketPricing
{
    public class NonDiscountPolicy : IDiscountPolicy
    {
        public Price CalculatePrice(Price price)
        {
            return price;
        }
    }
}
