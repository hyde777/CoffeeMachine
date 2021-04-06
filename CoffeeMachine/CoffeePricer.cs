using System;
using System.Collections.Generic;
using System.Linq;
using CoffeeMachine;

namespace CoffeeMachine
{
    public class CoffeePricer : ICoffeePricer
    {
        private readonly Dictionary<string, IBeverage> _recipes;

        public CoffeePricer()
        {
            _recipes = new()
            {
                {"Expresso", new Beverage(new List<IIngredient> {new Coffee(), new Water()})},
                {
                    "Cappucino", new Beverage(new List<IIngredient>
                        {new Coffee(), new Water(), new Cream(), new Chocolate()})
                },
                {"Allongé", new Beverage(new List<IIngredient> {new Coffee(), new Water(), new Water()})},
            };
        }

        public decimal Command(string beverage) => _recipes.FirstOrDefault(b => b.Key == beverage).Value.Price();
    }
}