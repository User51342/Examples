using System;

namespace CompositePatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalAmount = 1057;
            Console.WriteLine($"The lot of killing the monster is {totalAmount}.");
            var hans = new Person("Hans");
            var susi = new Person("Susi");
            var john = new Person("John");
            var ronald = new Person("Ronald");
            var jessi = new Person("Jessi");
            var averell = new Person("Averell");
            var jack = new Person("Jack");
            var william = new Person("William");
            var joe = new Person("Joe");
            var daltons = new Group { Members = { joe, william, jack, averell } };
            var developer = new Group() { Members = { ronald, jessi , daltons} };

            var party = new Group { Members = { hans, susi, john, developer } };
            party.Gold = totalAmount;
            party.Status();
            Console.ReadLine();
        }
    }
}
