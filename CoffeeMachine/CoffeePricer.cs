using System;

namespace CoffeeMachine
{
    public class CoffeePricer : ICoffeePricer
    {
        public decimal Command(string beverage) =>
            beverage switch
            {
                "Expresso" => new Expresso().Price(),
                "Cappucino" => new Cappucino().Price(),
                "Allongé" => new Elongated().Price(),
                _ => throw new Exception()
            };
    }
}