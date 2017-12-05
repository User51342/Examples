using FactoryPatternExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarFactory factory = LoadFactory();
            var car = factory.CreateEconomyCar();
            car.TurnOn();
            car.TurnOff();
            car = factory.CreateFamilyCar();
            car.TurnOn();
            car.TurnOff();
            car = factory.CreateSportsCar();
            car.TurnOn();
            car.TurnOff();
        }

        private static ICarFactory LoadFactory()
        {
            var FactoryName = Properties.Settings.Default.FactoryName;
            return Assembly.GetExecutingAssembly().CreateInstance(FactoryName) as ICarFactory;
        }
    }
}
