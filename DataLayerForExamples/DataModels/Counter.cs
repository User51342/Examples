using System.Data.Linq.Mapping;
using DataLayerForExamples.Interfaces;

namespace DataLayerForExamples.DataModels
{
    [Table(Name = "Counters")]
    public class Counter : IEntity
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public int Number { get; set; }
    }
}
