using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using AdapterPatternExample.Interfaces;
using AdapterPatternExample.Models;
using AdapterPatternExample.Renderer;

namespace AdapterPatternExample.Adapter
{
   public class PatternRendererAdapter : IDataPatternRendererAdapter
   {
       private DataRenderer _DataRenderer;
        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            _DataRenderer = new DataRenderer(new PatternCollectionDBAdapter(patterns));
            var writer = new StringWriter();
            _DataRenderer.Render(writer);
            return writer.ToString();
        }

        internal class PatternCollectionDBAdapter : IDbDataAdapter
        {
            private readonly IEnumerable<Pattern> _Patterns;

            public PatternCollectionDBAdapter(IEnumerable<Pattern> patterns)
            {
                _Patterns = patterns;
            }

            public int Fill(DataSet dataSet)
            {
                var dataTable = new DataTable();
                dataTable.Columns.Add(new DataColumn("Id", typeof(int)));
                dataTable.Columns.Add(new DataColumn("Name", typeof(string)));
                dataTable.Columns.Add(new DataColumn("Description", typeof(string)));

                foreach (var pattern in _Patterns)
                {
                    var newRow = dataTable.NewRow();
                    newRow[0] = pattern.Id;
                    newRow[1] = pattern.Name;
                    newRow[2] = pattern.Description;
                    dataTable.Rows.Add(newRow);
                }

                dataSet.Tables.Add(dataTable);
                dataSet.AcceptChanges();
                return dataTable.Rows.Count;
            }

            #region Not implemented
            public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
            {
                throw new NotImplementedException();
            }

   

            public IDataParameter[] GetFillParameters()
            {
                throw new NotImplementedException();
            }

            public int Update(DataSet dataSet)
            {
                throw new NotImplementedException();
            }

            public MissingMappingAction MissingMappingAction { get; set; }
            public MissingSchemaAction MissingSchemaAction { get; set; }
            public ITableMappingCollection TableMappings { get; }
            public IDbCommand SelectCommand { get; set; }
            public IDbCommand InsertCommand { get; set; }
            public IDbCommand UpdateCommand { get; set; }
            public IDbCommand DeleteCommand { get; set; }
            #endregion
        }
   }
}
