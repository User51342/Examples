namespace MediatorPatternExample
{
    public class Airbus : Aircraft
    {
        public Airbus(string callSign, IMediator tower) : base(callSign, tower)
        {
        }
    }
}
