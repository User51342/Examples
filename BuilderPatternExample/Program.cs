using BuilderPatternExample.Builder;
using System;

namespace BuilderPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var sandwichMaker = new SandwichMaker(new ClubSandwichBuilder());
            sandwichMaker.BuildSandwich();
            var sandwich = sandwichMaker.GetSandwich();
            sandwich.Display();

            sandwichMaker = new SandwichMaker(new VegieSandwichBuilder());
            sandwichMaker.BuildSandwich();
            sandwich = sandwichMaker.GetSandwich();
            sandwich.Display();

            Console.ReadLine();
        }
    }
}
