using System.Collections.Generic;
using System.Linq;

namespace MediatorPatternExample
{
   public class Tower : IMediator
    {
        readonly List<Aircraft> _aircrafts = new List<Aircraft>();
        #region IMediator implementation
        public void InformOther(string message, string originCallSign)
        {
            foreach (var aircraft in _aircrafts.Where(a => a.CallSign != originCallSign))
            {
                aircraft.GetMessage(message);
            }
        }

        public void RegisterAircraft(Aircraft aircraft)
        {
            _aircrafts.Add(aircraft);
        }
        #endregion
    }
}
