namespace MediatorPatternExample
{
    public interface IMediator
    {
        void InformOther(string message, string originalCallSign);
        void RegisterAircraft(Aircraft aircraft);
    }
}
