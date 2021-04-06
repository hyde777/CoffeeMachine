namespace CoffeeMachine
{
    public class Coffee : IIngredient
    {
        public decimal Price() => new(1);
    }
}