using System;
using System.Threading;

namespace ThreadSafeSingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.Instance;
            Console.WriteLine($"Singleton created at {singleton.ToString()}");
            Thread.Sleep(3000);
            Console.WriteLine($"Singleton created at {singleton.ToString()}");
            Thread.Sleep(3000);
            Console.WriteLine($"Singleton created at {singleton.ToString()}");
            Thread.Sleep(3000);
        }
    }
}
