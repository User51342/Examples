using FactoryPatternExample.Interfaces;
using System;

namespace FactoryPatternExample.Factories.CarFactories.Toyota
{
    public class Prius : ICar
    {
        public string Name => "Toyota Prius";

        public void TurnOn()
        {
            Console.WriteLine($"Turned on the {Name}.");
        }

        public void TurnOff()
        {
            Console.WriteLine($"Turned off the {Name}.");
        }

        public void AddPulsPackage()
        { }
    }
}
