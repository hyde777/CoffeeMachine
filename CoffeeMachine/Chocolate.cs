namespace CoffeeMachine
{
    public class Chocolate : IIngredient
    {
        private readonly int _amount;

        public Chocolate(int amount)
        {
            _amount = amount;
        }

        public Chocolate() : this(1){}

        public decimal Price() => new(1 * _amount);
    }
}