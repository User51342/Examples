using System.Configuration;
using System.Data.Linq;
using DataLayerForExamples.DataModels;
using DataLayerForExamples.Interfaces;

namespace DataLayerForExamples
{
    public class SqlUnitOfWork : IUnitOfWork
    {
        #region Fields
        private readonly DataContext _context;
        private SqlRepository<Counter> _counters;
        #endregion

        public SqlUnitOfWork()
        {
            //var conString = ConfigurationManager.ConnectionStrings["ExamplesDbEntities"].ConnectionString;
            var conString = ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString;
            _context = new DataContext(conString);
        }

        public IRepository<Counter> Counters
        {
            get
            {
                if (_counters == null)
                {
                    _counters = new SqlRepository<Counter>(_context);
                }
                return _counters;
            }

        }
        public void Commit()
        {
            _context.SubmitChanges();
        }
    }
}
