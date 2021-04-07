using System.Collections.Generic;
using CoffeeMachine;
using FluentAssertions;
using NUnit.Framework;

namespace CoffeeMachineTests
{
    public class AcceptanceTests
    {
        private const string CAPPUCINO = "Cappucino";
        private const string EXPRESSO = "Expresso";
        private const string ALLONGER = "Allongé";
        private const string CHOCOLAT = "Chocolat";
        private readonly decimal _waterPrice = new(0.2);
        private readonly decimal _coffeePrice = new(1);
        private readonly decimal _creamPrice = new(0.5);
        private readonly decimal _chocolatePrice = new(1);
        private readonly ICoffeePricer _pricer;
        private decimal _margin;

        public AcceptanceTests()
        {
            _pricer = new CoffeePricer(Recipes());
        }

        private Dictionary<string, IBeverage> Recipes()
        {
            _margin = new decimal(0.3);
            return new()
            {
                {EXPRESSO, new Beverage(new List<IIngredient> {new Coffee(), new Water()}, _margin)},
                {
                    CAPPUCINO, new Beverage(new List<IIngredient>
                        {new Coffee(), new Water(), new Cream(), new Chocolate()}, _margin)
                },
                {ALLONGER, new Beverage(new List<IIngredient> {new Coffee(), new Water(2)}, _margin)},
                {CHOCOLAT, new Beverage(new List<IIngredient> {new Chocolate(3), new Water(), new Sugar(), new Milk(2)}, _margin)},
            };
        }

        [Test]
        public void ShouldPriceAnExpresso()
        {
            decimal expressoPrice = _waterPrice + _coffeePrice;

            decimal price = _pricer.Command(EXPRESSO);

            decimal margin = expressoPrice * _margin;
            price.Should().Be(expressoPrice + margin);
        }

        [Test]
        public void ShouldPriceAnElongated()
        {
            decimal elongated = _waterPrice * 2 + _coffeePrice;

            decimal price = _pricer.Command(ALLONGER);

            decimal margin = elongated * _margin;
            price.Should().Be(elongated + margin);
        }

        [Test]
        public void ShouldPriceACapuccino()
        {
            decimal cappucinno = _waterPrice + _coffeePrice + _chocolatePrice + _creamPrice;

            decimal price = _pricer.Command(CAPPUCINO);

            decimal margin = cappucinno * _margin;
            price.Should().Be(cappucinno + margin);
        }
        
        [Test]
        public void ShouldPriceAChocolate()
        {
            decimal milkPrice = new (0.4);
            decimal sugarPrice = new (0.1);
            decimal cappucinno = _waterPrice + _chocolatePrice * 3 + milkPrice * 2 + sugarPrice;

            decimal price = _pricer.Command(CHOCOLAT);

            decimal margin = cappucinno * _margin;
            price.Should().Be(cappucinno + margin);
        }
    }
}