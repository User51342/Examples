using System;
using System.Linq;
using System.Linq.Expressions;

namespace DataLayerForExamples.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Remove(T entity);
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
    }
}
