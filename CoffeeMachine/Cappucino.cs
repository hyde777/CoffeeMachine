using System.Collections.Generic;
using System.Linq;

namespace CoffeeMachine
{
    public class Cappucino : IBeverage
    {
        private IEnumerable<IIngredient> _ingredients;

        public Cappucino()
        {
            _ingredients = new List<IIngredient>{new Coffee(), new Water(), new Cream(), new Chocolate()};
        }

        public decimal Price()
        {
            return _ingredients.Select(x => x.Price()).Sum();
        }
    }
}