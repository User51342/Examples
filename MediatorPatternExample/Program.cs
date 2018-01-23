using System;

namespace MediatorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var tower = new Tower();
            var boeing = new Boeing("BO 534", tower);
            var airbus = new Airbus("AB 873", tower);
            boeing.SetMessage("Hallo, ich bin die Boeing!");
            airbus.SetMessage("Hallo Boeing, here is Airbus speeking.");
            Console.ReadLine();
        }
    }
}
