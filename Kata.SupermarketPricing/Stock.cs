using Kata.SupermarketPricing;
using System;

namespace Kata.SupermarketPricing
{
    public class Stock
    {
        public static Stock EmptyStock { get { return new Stock(0); } }
        public Stock(int amount)
        {
            if (amount < 0)
                throw new ArgumentException("Amount cannot be lower then zero");

            _amount = amount;
        }

        public Price CalculateValue(Price price, IDiscountPolicy discountPolicy)
        {
            var priceAfterDiscount = discountPolicy.CalculatePrice(price);
            return _amount * priceAfterDiscount;
        }

        public Price CalculateValue(Price price)
        {
            return CalculateValue(price, new NonDiscountPolicy());
        }

        private int _amount;

        public bool IsEmpty
        {
            get { return _amount == 0; }
        }

        public void Add(int amount)
        {
            _amount += amount;
        }
    }
}
