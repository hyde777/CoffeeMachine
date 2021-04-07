namespace CoffeeMachine.Ingredients
{
    public class Coffee : IIngredient
    {
        public decimal Price() => new(1);
    }
}