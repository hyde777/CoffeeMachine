namespace CoffeeMachine
{
    public class Water : IIngredient
    {
        private const double UNIT_PRICE = 0.2;
        private readonly int _amount;

        public Water(int amount)
        {
            _amount = amount;
        }

        public Water() : this(1){}
        public decimal Price() => new(UNIT_PRICE * _amount);
    }
}