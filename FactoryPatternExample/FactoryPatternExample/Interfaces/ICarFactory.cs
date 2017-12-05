namespace FactoryPatternExample.Interfaces
{
    interface ICarFactory
    {
        ICar CreateEconomyCar();
        ICar CreateFamilyCar();
        ICar CreateSportsCar();
    }
}
