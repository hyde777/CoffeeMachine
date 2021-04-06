namespace CoffeeMachine
{
    public class Water : IIngredient
    {
        public decimal Price() => new(0.2);
    }
}