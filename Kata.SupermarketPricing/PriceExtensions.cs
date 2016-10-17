using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.SupermarketPricing
{
    public static class PriceExtensions
    {
        public static Price ToPrice(this int value)
        {
            return new Price(value);
        }
        public static Price ToPrice(this decimal value)
        {
            return new Price(value);
        }
    }
}
