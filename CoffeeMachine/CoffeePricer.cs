using System;
using System.Collections.Generic;

namespace CoffeeMachine
{
    public class CoffeePricer : ICoffeePricer
    {
        public decimal Command(string beverage) =>
            beverage switch
            {
                "Expresso" => new Beverage(new List<IIngredient>() {new Coffee(), new Water()}).Price(),
                "Cappucino" => new Beverage(new List<IIngredient>{new Coffee(), new Water(), new Cream(), new Chocolate()}).Price(),
                "Allongé" => new Beverage(new List<IIngredient> { new Coffee(), new Water(), new Water()}).Price(),
                _ => throw new Exception()
            };
    }
}