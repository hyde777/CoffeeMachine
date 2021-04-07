namespace CoffeeMachine.Ingredients
{
    public class Cream : IIngredient
    {
        public decimal Price() => new(0.5);
    }
}