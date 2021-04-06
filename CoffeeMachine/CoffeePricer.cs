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

        public decimal Command(string beverage) => _recipes.FirstOrDefault(b => b.Key == beverage).Value.Price();
    }
}