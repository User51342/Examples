using DataLayerForExamples.DataModels;

namespace DataLayerForExamples.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Counter> Counters { get; }
        void Commit();
    }
}
