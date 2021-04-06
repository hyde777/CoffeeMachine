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

        [Test]
        public void ShouldPriceAnExpresso()
        {
            decimal expressoPrice = _waterPrice + _coffeePrice;
            ICoffeePricer pricer = new CoffeePricer();

            decimal price = pricer.Command("Expresso");

            price.Should().Be(expressoPrice);
        }

        [Test]
        public void ShouldPriceAnElongated()
        {
            decimal elongated = _waterPrice * 2 + _coffeePrice;
            ICoffeePricer pricer = new CoffeePricer();

            decimal price = pricer.Command("Allongé");

            price.Should().Be(elongated);
        }

        [Test]
        public void ShouldPriceACapuccino()
        {
          
            decimal cappucinno = _waterPrice + _coffeePrice + _chocolatePrice + _creamPrice;
            ICoffeePricer pricer = new CoffeePricer();

            decimal price = pricer.Command("Cappucino");
            
            price.Should().Be(cappucinno);
        }
    }
}