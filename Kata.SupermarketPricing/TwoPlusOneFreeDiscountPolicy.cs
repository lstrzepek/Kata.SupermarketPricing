using System;

namespace Kata.SupermarketPricing
{
    public class TwoPlusOneFreeDiscountPolicy : IDiscountPolicy
    {
        public TwoPlusOneFreeDiscountPolicy(int amount)
        {
            _amount = amount;
        }

        private int _amount;
        public Price CalculatePrice(Price price)
        {
            var freeItemsAmount = _amount / 3;
            if (freeItemsAmount == 0)
                return price;
            return ((_amount - freeItemsAmount) * price)/_amount;
        }
    }
}
