namespace Kata.SupermarketPricing
{
    public struct Price
    {
        public Price(decimal value)
        {
            _value = value;
        }

        private decimal _value;

        public static Price operator * (int amount, Price price)
        {
            return new Price(price._value * amount);
        }
        public static Price operator /(Price price, int amount)
        {
            return new Price(price._value / amount);
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}