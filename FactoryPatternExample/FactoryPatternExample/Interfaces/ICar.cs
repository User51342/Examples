namespace FactoryPatternExample.Interfaces
{
    public interface ICar
    {
        string Name { get; }
        void TurnOn();
        void TurnOff();
    }
}