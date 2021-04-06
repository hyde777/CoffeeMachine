namespace CoffeeMachine
{
    public class CoffeePricer : ICoffeePricer
    {
        public decimal Command(string beverage)
        {
            return new(1.2);
        }
    }
}