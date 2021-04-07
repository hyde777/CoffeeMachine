namespace CoffeeMachine.Ingredients
{
    public class Sugar : IIngredient
    {
        public decimal Price()
        {
            return new(0.1);
        }
    }
}