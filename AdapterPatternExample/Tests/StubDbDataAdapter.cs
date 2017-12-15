using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample.Tests
{
    public class StubDBDataAdabter : IDbDataAdapter
    {
        public int Fill(DataSet dataSet)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("Id", typeof(int)));
            dataTable.Columns.Add(new DataColumn("Name", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Description", typeof(string)));
            var newRow = dataTable.NewRow();
            newRow[0] = 1;
            newRow[1] = "Adapter";
            newRow[2] = "Adapter Description";
            dataTable.Rows.Add(newRow);
            dataSet.Tables.Add(dataTable);
            dataSet.AcceptChanges();
            return 1;
        }

        #region Not implemented
        public IDbCommand SelectCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDbCommand InsertCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDbCommand UpdateCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDbCommand DeleteCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public MissingMappingAction MissingMappingAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public MissingSchemaAction MissingSchemaAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ITableMappingCollection TableMappings => throw new NotImplementedException();



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
        #endregion
    }
}
