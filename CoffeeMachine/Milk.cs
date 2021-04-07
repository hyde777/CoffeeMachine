namespace CoffeeMachine
{
    public class Milk : IIngredient
    {
        private const double UNITARY_PRICE = 0.4;
        private readonly int _amount;

        public Milk(int amount)
        {
            _amount = amount;
        }

        public decimal Price()
        {
            return new(UNITARY_PRICE * _amount);
        }
    }
}