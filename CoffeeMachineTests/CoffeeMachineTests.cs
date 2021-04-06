using CoffeeMachine;
using FluentAssertions;
using NUnit.Framework;

namespace CoffeeMachineTests
{
    public class AcceptanceTests
    {
        [Test]
        public void ShouldPriceAnExpresso()
        {
            decimal waterPrice = new(0.2);
            decimal coffeePrice = new(1);
            ICoffeePricer pricer = new CoffeePricer();

            decimal price = pricer.Command("Expresso");

            decimal expressoPrice = waterPrice + coffeePrice;
            price.Should().Be(expressoPrice);
        }
    }
}