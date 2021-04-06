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
            return _ingredients.Select(x => x.Price()).Sum();
        }
    }
}