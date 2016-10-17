namespace Kata.SupermarketPricing
{
    public interface IDiscountPolicy
    {
        Price CalculatePrice(Price price);
    }
}