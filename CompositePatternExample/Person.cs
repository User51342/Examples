using System;

namespace CompositePatternExample
{
    public class Person : IParty
    {
        #region Fields
        private int _gold;
        private readonly string name;
        #endregion

        #region Properties
        public int Gold
        {
            get => _gold;
            set => _gold = value;
        }
        #endregion

        #region Construction / Initialization / Deconstruction
        public Person(string name)
        {
            this.name = name;
        }
        #endregion

        #region Public implementations
        public void Status()
        {
            Console.WriteLine($"{name} has {_gold} gold.");
        }
        #endregion
    }
}
