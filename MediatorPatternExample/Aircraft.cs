using System;

namespace MediatorPatternExample
{
    public abstract class Aircraft
    {
        #region Fields
        private readonly IMediator _tower;

        #endregion

        #region Properties
        public string CallSign { get; }

        #endregion

        #region Construction / Initalization / deconstruction

        protected Aircraft(string callSign, IMediator tower)
        {
            _tower = tower;
            CallSign = callSign;
            tower.RegisterAircraft(this);
        }
        #endregion

        #region Public implemetations
        public void GetMessage(string message)
        {
            Console.WriteLine($"{CallSign} get the Message {message}");
        }

        public void SetMessage(string message)
        {
            _tower.InformOther(message, CallSign);
        }
        #endregion
    }
}
