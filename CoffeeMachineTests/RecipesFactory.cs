using System.Collections.Generic;
using CoffeeMachine;
using CoffeeMachine.Ingredients;

namespace CoffeeMachineTests
{
    public class RecipesFactory
    {
        private const string CAPPUCINO = "Cappucino";
        private const string EXPRESSO = "Expresso";
        private const string ALLONGER = "Allongé";
        private const string CHOCOLAT = "Chocolat";
        private const string THE = "Thé";

        public Dictionary<string, IBeverage> Recipes()
        {
            var margin = new decimal(0.3);
            return new()
            {
                {EXPRESSO, new Beverage(new List<IIngredient> {new Coffee(), new Water()}, margin)},
                {
                    CAPPUCINO, new Beverage(new List<IIngredient>
                        {new Coffee(), new Water(), new Cream(), new Chocolate()}, margin)
                },
                {ALLONGER, new Beverage(new List<IIngredient> {new Coffee(), new Water(2)}, margin)},
                {CHOCOLAT, new Beverage(new List<IIngredient> {new Chocolate(3), new Water(), new Sugar(), new Milk(2)}, margin)},
                {
                    THE, new Beverage(new List<IIngredient>
                    {
                        new Water(2), new Tea()
                    }, margin)},
            };
        }
    }
}