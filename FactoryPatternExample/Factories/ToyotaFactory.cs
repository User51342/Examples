using FactoryPatternExample.Factories.CarFactories.Toyota;
using FactoryPatternExample.Interfaces;

namespace FactoryPatternExample.Factories
{
    public class ToyotaFactory : ICarFactory
    {
        public ICar CreateEconomyCar()
        {
            return new Prius();
        }

        public ICar CreateFamilyCar()
        {
            var prius = new Prius();
            prius.AddPulsPackage();
            return prius;
        }

        public ICar CreateSportsCar()
        {
            return new GT86();
        }
    }
}
