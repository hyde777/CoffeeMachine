using System.Collections.Generic;
using CoffeeMachine;
using FluentAssertions;
using NUnit.Framework;

namespace CoffeeMachineTests
{
    public class AcceptanceTests
    {
        private readonly decimal _waterPrice = new(0.2);
        private readonly decimal _coffeePrice = new(1);
        private readonly decimal _creamPrice = new(0.5);
        private readonly decimal _chocolatePrice = new(1);
        private readonly ICoffeePricer _pricer;

        public AcceptanceTests()
        {
            _pricer = new CoffeePricer(Recipes());
        }

        private Dictionary<string, IBeverage> Recipes()
        {
            return new()
            {
                {"Expresso", new Beverage(new List<IIngredient> {new Coffee(), new Water()})},
                {
                    "Cappucino", new Beverage(new List<IIngredient>
                        {new Coffee(), new Water(), new Cream(), new Chocolate()})
                },
                {"Allongé", new Beverage(new List<IIngredient> {new Coffee(), new Water(2)})},
            };
        }

        [Test]
        public void ShouldPriceAnExpresso()
        {
            decimal expressoPrice = _waterPrice + _coffeePrice;

            decimal price = _pricer.Command("Expresso");

            decimal margin = expressoPrice * new decimal(0.3);
            price.Should().Be(expressoPrice + margin);
        }

        [Test]
        public void ShouldPriceAnElongated()
        {
            decimal elongated = _waterPrice * 2 + _coffeePrice;

            decimal price = _pricer.Command("Allongé");

            decimal margin = elongated * new decimal(0.3);
            price.Should().Be(elongated + margin);
        }

        [Test]
        public void ShouldPriceACapuccino()
        {
            decimal cappucinno = _waterPrice + _coffeePrice + _chocolatePrice + _creamPrice;

            decimal price = _pricer.Command("Cappucino");

            decimal margin = cappucinno * new decimal(0.3);
            price.Should().Be(cappucinno + margin);
        }
    }
}