using System.Collections.Generic;
using System.Linq;

namespace CoffeeMachine
{
    public class Beverage : IBeverage
    {
        private readonly List<IIngredient> _ingredients;

        public Beverage(List<IIngredient> ingredients)
        {
            _ingredients = ingredients;
        }

        public decimal Price()
        {
            decimal price = _ingredients.Select(x => x.Price()).Sum();
            decimal margin = price * new decimal(0.3);
            return price + margin;
        }
    }
}