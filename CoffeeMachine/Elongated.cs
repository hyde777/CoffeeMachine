using System.Collections.Generic;
using System.Linq;

namespace CoffeeMachine
{
    public class Elongated : IBeverage
    {
        private readonly IEnumerable<IIngredient> _ingredients;

        public Elongated()
        {
            _ingredients = new List<IIngredient> { new Coffee(), new Water(), new Water()};
        }

        public decimal Price()
        {
            return _ingredients.Select(x => x.Price()).Sum();
        }
    }
}