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

            return new(1.4);
        }
    }
}