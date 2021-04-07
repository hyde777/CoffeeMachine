using System;
using System.Collections.Generic;
using System.Linq;
using CoffeeMachine;

namespace CoffeeMachine
{
    public class CoffeePricer : ICoffeePricer
    {
        private readonly Dictionary<string, IBeverage> _recipes;

        public CoffeePricer(Dictionary<string, IBeverage> recipes)
        {
            _recipes = recipes;
        }

        public decimal Command(string beverage)
        {
            KeyValuePair<string,IBeverage> recipe = _recipes.FirstOrDefault(b => b.Key == beverage);
            if (recipe.Value is null) { throw new Exception($"La recette {beverage} n'existe pas");}
            return recipe.Value.Price();
        }
    }
}