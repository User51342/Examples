using FactoryPatternExample.Factories.CarFactories.Tesla;
using FactoryPatternExample.Interfaces;

namespace FactoryPatternExample.Factories
{
    public class TeslaFactory : ICarFactory
    {
        public ICar CreateEconomyCar()
        {
            return new Model3();
        }

        public ICar CreateFamilyCar()
        {
            return new ModelX();
        }

        public ICar CreateSportsCar()
        {
            return new Roadster();
        }
    }
}
