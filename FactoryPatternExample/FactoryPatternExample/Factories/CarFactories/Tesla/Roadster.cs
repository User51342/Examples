using FactoryPatternExample.Interfaces;
using System;

namespace FactoryPatternExample.Factories.CarFactories.Tesla
{
    public class Roadster : ICar
    {
        public string Name => "Tesla Roadster";

        public void TurnOff()
        {
            Console.WriteLine($"Turned on the {Name}.");
        }

        public void TurnOn()
        {
            Console.WriteLine($"Turned off the {Name}.");
        }
    }
}
