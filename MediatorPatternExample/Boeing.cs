namespace MediatorPatternExample
{
    public class Boeing : Aircraft
    {
        public Boeing(string callSign, IMediator tower) : base(callSign, tower)
        {
        }
    }
}
