using System.Collections.Generic;

namespace CompositePatternExample
{
    public class Group : IParty
    {
        private List<IParty> group = new List<IParty>();
        #region Properties
        public int Gold
        {
            get
            {
                int totalGold = 0;
                foreach (var member in group)
                {
                    totalGold += member.Gold;
                }
                return totalGold;
            }
            set
            {
                var share = value / group.Count;
                var leftover = value % group.Count;
                foreach (var member in group)
                {
                    member.Gold = share + leftover;
                    leftover = 0;
                }
            }
        }
        #endregion

        #region Properties
        public List<IParty> Members
        {
            get { return group; }
            set { group = value; }
        }
        #endregion

        #region Construction / Initialization / Deconstruction
        #endregion

        #region Public implementations
        public void Status()
        {
            foreach (var member in group)
            {
                member.Status();
            }
        }
        #endregion
    }
}
