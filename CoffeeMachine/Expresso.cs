using System.Collections.Generic;
using System.Linq;

namespace CoffeeMachine
{
    public class Expresso : IBeverage
    {
        private readonly List<IIngredient> _ingredients;

        public Expresso()
        {
            _ingredients = new List<IIngredient>() {new Coffee(), new Water()};
        }

        public decimal Price()
        {
            return _ingredients.Select(x => x.Price()).Sum();
        }
    }
}