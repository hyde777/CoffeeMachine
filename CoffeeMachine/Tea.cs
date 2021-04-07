namespace CoffeeMachine
{
    public class Tea : IIngredient
    {
        public decimal Price()
        {
            return new(2);
        }
    }
}