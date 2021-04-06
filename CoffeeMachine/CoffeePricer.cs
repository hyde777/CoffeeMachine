namespace CoffeeMachine
{
    public class CoffeePricer : ICoffeePricer
    {
        public decimal Command(string beverage)
        {
            if (beverage is "Expresso")
            {
                return new(1.2);
            }

            if (beverage is "Cappucino")
            {
                return new decimal(1) + new decimal(0.2) + new decimal(0.5) + new decimal(1);
            }
            return new(1.4);
        }
    }
}