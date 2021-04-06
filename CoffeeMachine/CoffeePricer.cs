using System;

namespace CoffeeMachine
{
    public class CoffeePricer : ICoffeePricer
    {
        public decimal Command(string beverage)
        {
            decimal waterPrice = new(0.2);
            decimal coffeeOrChocolate = new(1);
            decimal cream = new(0.5);
            
            if (beverage is "Expresso")
            {
                return coffeeOrChocolate + waterPrice;
            }

            if (beverage is "Cappucino")
            {
                return coffeeOrChocolate + waterPrice + cream + coffeeOrChocolate;
            }

            if (beverage is "Allongé")
            {
                return coffeeOrChocolate + waterPrice * 2;
            }

            throw new Exception();
        }
    }
}