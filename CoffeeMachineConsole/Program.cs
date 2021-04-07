using System;
using CoffeeMachine;
using CoffeeMachineConsole;

string input = args[0];
try
{
    decimal price = new CoffeePricer(new RecipesFactory().Recipes()).Command(input);
    Console.WriteLine($"The ${input} cost {price}€");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
