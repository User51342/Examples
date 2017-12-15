using System;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using DataLayerForExamples.Interfaces;

namespace DataLayerForExamples.DataModels
{
    public class SqlRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly Table<T> _objectSet;

        public SqlRepository(DataContext context)
        {
            _objectSet = context.GetTable<T>();
        }

        public void Add(T entity)
        {
            _objectSet.InsertOnSubmit(entity);
        }

        public void Remove(T entity)
        {
            _objectSet.DeleteOnSubmit(entity);
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _objectSet.Where(predicate);
        }
    }
}
