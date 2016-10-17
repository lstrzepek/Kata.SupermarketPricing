using NUnit.Framework;

namespace Kata.SupermarketPricing.Tests
{
    [TestFixture]
    public class NonDiscountPolicyTest
    {
        [Test]
        public void Discount_PriceStaysTheSame() {
            var price = new Price(4.5M);
            var discount = new NonDiscountPolicy();
            var priceAfterDiscount = discount.CalculatePrice(price);
            Assert.That(priceAfterDiscount, Is.EqualTo(price));
        }
    }
}
