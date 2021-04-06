using System;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeMachine
{
    public class CoffeePricer : ICoffeePricer
    {
        public decimal Command(string beverage)
        {
            if (beverage is "Expresso")
            {
                return new Expresso().Price();
            }

            if (beverage is "Cappucino")
            {
                return new Cappucino().Price();
            }

            if (beverage is "Allongé")
            {
                return new Elongated().Price();
            }

            throw new Exception();
        }

   
    }

    public interface IBeverage
    {
        decimal Price();
    }

    public class Elongated : IBeverage
    {
        private readonly IEnumerable<IIngredient> _ingredients;

        public Elongated()
        {
            _ingredients = new List<IIngredient> { new Coffee(), new Water(), new Water()};
        }

        public decimal Price()
        {
            return _ingredients.Select(x => x.Price()).Sum();
        }
    }

    public class Cappucino : IBeverage
    {
        private IEnumerable<IIngredient> _ingredients;

        public Cappucino()
        {
            _ingredients = new List<IIngredient>{new Coffee(), new Water(), new Cream(), new Chocolate()};
        }

        public decimal Price()
        {
            return _ingredients.Select(x => x.Price()).Sum();
        }
    }

    public class Expresso : IBeverage
    {
        private readonly List<IIngredient> _ingredients;

        public Expresso()
        {
            _ingredients = new List<IIngredient>() {new Coffee(), new Water()};
        }

        public decimal Price()
        {
            return _ingredients.Select(x => x.Price()).Sum();
        }
    }


    public interface IIngredient
    {
        decimal Price();
    }

    public class Cream : IIngredient
    {
        public decimal Price() => new(0.5);
    }

    public class Chocolate : IIngredient
    {
        public decimal Price() => new(1);
    }

    public class Coffee : IIngredient
    {
        public decimal Price() => new(1);
    }

    public class Water : IIngredient
    {
        public decimal Price() => new(0.2);
    }
}