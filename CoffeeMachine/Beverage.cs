using System.Collections.Generic;
using System.Linq;
using CoffeeMachine.Ingredients;

namespace CoffeeMachine
{
    public class Beverage : IBeverage
    {
        private readonly List<IIngredient> _ingredients;
        private readonly decimal _margin;

        public Beverage(List<IIngredient> ingredients, decimal margin)
        {
            _ingredients = ingredients;
            _margin = margin;
        }

        public decimal Price()
        {
            decimal price = _ingredients.Select(x => x.Price()).Sum();
            decimal taxe = price * _margin;
            return price + taxe;
        }
    }
}