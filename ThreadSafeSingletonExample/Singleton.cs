using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadSafeSingletonExample
{
    public class Singleton
    {
        private DateTime created;
        private Singleton()
        {
            created = DateTime.Now;
        }
        private DateTime Created { get { return Created; } }
        public static Singleton Instance { get { return Nested.instance; } }

        public override string ToString()
        {
            return created.ToString();
        }
        private class Nested
        {
            static Nested()
            {
            }

            internal static Singleton instance = new Singleton();
        }
    }
}
