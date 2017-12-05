using FactoryPatternExample.Interfaces;
using System.Reflection;

namespace FactoryPatternExample
{
    /// <summary>
    /// See <see cref="https://app.pluralsight.com/player?course=patterns-library&author=david-starr&name=pattern-factories&clip=0&mode=live">Pluralsight course</see>
    ///  </summary>
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
