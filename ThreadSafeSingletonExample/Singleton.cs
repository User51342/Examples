using System;

namespace ThreadSafeSingletonExample
{
    public class Singleton
    {
        #region Fields
        private DateTime created;
        #endregion

        #region Properties
        private DateTime Created { get { return Created; } }
        public static Singleton Instance { get { return Nested.instance; } }
        #endregion

        #region Construction / Initialization / Deconstruction
        private Singleton()
        {
            created = DateTime.Now;
        }
        #endregion

        #region Public implementations
        public override string ToString()
        {
            return created.ToString();
        }
        #endregion

        #region Nested class
        private class Nested
        {
            static Nested()
            {
            }

            internal static readonly Singleton instance = new Singleton();
        }
        #endregion
    }
}
