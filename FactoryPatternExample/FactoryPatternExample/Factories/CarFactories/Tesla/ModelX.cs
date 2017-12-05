using FactoryPatternExample.Interfaces;
using System;

namespace FactoryPatternExample.Factories.CarFactories.Tesla
{
    public class ModelX : ICar
    {
        public string Name => "Tesla Model X";

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
