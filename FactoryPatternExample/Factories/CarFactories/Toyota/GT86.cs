using FactoryPatternExample.Interfaces;
using System;

namespace FactoryPatternExample.Factories.CarFactories.Toyota
{
    public class GT86 : ICar
    {
        public string Name => "Toyota GT86";

        public void TurnOff()
        {
            Console.WriteLine($"Turned on the {Name}.");
        }

        public void TurnOn()
        {
            Console.WriteLine($"Turned on the {Name}.");
        }
    }
}
