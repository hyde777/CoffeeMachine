namespace CoffeeMachine
{
    public interface ICoffeePricer
    {
        decimal Command(string beverage);
    }
}