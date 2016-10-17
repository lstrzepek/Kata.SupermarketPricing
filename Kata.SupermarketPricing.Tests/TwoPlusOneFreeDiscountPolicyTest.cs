using NUnit.Framework;

namespace Kata.SupermarketPricing.Tests
{
    [TestFixture]
    public class TwoPlusOneFreeDiscountPolicyTest
    {
        [Test]
        public void Discount_WhenZeroAmount_ThenPriceStaysTheSame()
        {
            var price = 4.5M.ToPrice();
            var discount = new TwoPlusOneFreeDiscountPolicy(amount:0);
            var priceAfterDiscount = discount.CalculatePrice(price);
            Assert.That(priceAfterDiscount, Is.EqualTo(price));
        }

        [Test]
        public void Discount_WhenZeroPrice_ThenPriceStaysTheSame()
        {
            var price = 0.ToPrice();
            var discount = new TwoPlusOneFreeDiscountPolicy(amount:1);
            var priceAfterDiscount = discount.CalculatePrice(price);
            Assert.That(priceAfterDiscount, Is.EqualTo(price));
        }

        [Test]
        public void Discount_WhenAmountLowerThenThree_ThenPriceStaysTheSame()
        {
            var price = 4.5M.ToPrice();
            var discount = new TwoPlusOneFreeDiscountPolicy(amount:2);
            var priceAfterDiscount = discount.CalculatePrice(price);
            Assert.That(priceAfterDiscount, Is.EqualTo(price));
        }

        [TestCase(3, 4.5, 3)]
        [TestCase(4, 4.5, 3.375)]
        [TestCase(5, 4.5, 3.6)]
        [TestCase(6, 4.5, 3)]
        [TestCase(18, 4.5, 3)]
        public void Discount_WhenAmountGraterOrEqualThree_ThenApplyDiscount(int amount, decimal priceValue, decimal expectedDiscount)
        {
            var price = new Price(priceValue);
            var discount = new TwoPlusOneFreeDiscountPolicy(amount);
            var priceAfterDiscount = discount.CalculatePrice(price);
            Assert.That(priceAfterDiscount, Is.EqualTo(expectedDiscount.ToPrice()));
        }
    }
}
