using NUnit.Framework;
using System;

namespace Kata.SupermarketPricing.Tests
{
    [TestFixture]
    public class StockTest
    {
        [Test]
        public void Stock_WhenEmpty_HasZeroValue()
        {
            var stock = Stock.EmptyStock;
            Assert.That(stock.IsEmpty, Is.True);
            Assert.That(stock.CalculateValue(4.5M.ToPrice()), Is.EqualTo(0.ToPrice()));
        }

        [Test]
        public void Stock_WhenEmpty_StaysEmpty()
        {
            Assert.That(Stock.EmptyStock.IsEmpty, Is.True);
            Stock.EmptyStock.Add(2);
            Assert.That(Stock.EmptyStock.IsEmpty, Is.True);
        }

        [Test]
        public void Stock_WhenLowerThenZeroAmount_ThrowsArgmentException()
        {
            Assert.Throws<ArgumentException>(() => new Stock(-1));
        }

        [Test]
        public void Stock_WhenNotEmpty_HasValue()
        {
            var stock = new Stock(100);
            Assert.That(stock.CalculateValue(4.5M.ToPrice()), Is.EqualTo(450M.ToPrice()));
        }

    }
}
