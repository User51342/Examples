using FactoryPatternExample.Interfaces;
using System;

namespace FactoryPatternExample.Factories.CarFactories.Tesla
{
    public class Model3 : ICar
    {
        public string Name => "Tesla Model 3";

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
