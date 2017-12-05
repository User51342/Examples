using System;

namespace PrototypePatternExample
{
    public class StatusSwitcher : ICloneable
    {
        #region Fields
        private int status;
        #endregion

        #region Properties
        public int Status
        {
            get { return status; }
            private set { status = value; }
        }
        #endregion

        #region Construction / Initialization / Deconstruction
        public StatusSwitcher()
        {
            Status = 1;
        }
        #endregion

        #region Public implementation
        public object Clone()
        {
            return MemberwiseClone();
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"Status={Status}");
        }

        public void SwitchStatusTo(int newStatus)
        {
            Status = newStatus;
        }
        #endregion
    }
}
