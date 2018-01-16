using System;
using System.Linq;
using DataLayerForExamples;
using DataLayerForExamples.DataModels;

namespace RepositoryPatternExample
{
    public class Worker
    {
        public static void Run()
        {
            var unitOfWork = new SqlUnitOfWork();
            var counters = unitOfWork.Counters.Find(x => x.Id == 3).ToList();
            if (counters.Any())
            {
                var counter = counters.First();
                Console.WriteLine($"OldCounter: {counter.Number} with Id {counter.Id}.");
                counter.Number++;
                Console.WriteLine($"NewCounter: {counter.Number} with Id {counter.Id}.");
                unitOfWork.Commit();
            }
            else
            {
                var count = new Counter {Number = 0};
                unitOfWork.Counters.Add(count);
                unitOfWork.Commit();
                Console.WriteLine($"Created Counter with Id {count.Id}.");
            }

            Console.ReadLine();
        }
    }
}
