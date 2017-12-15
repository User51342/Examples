using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample.Renderer
{
    public class DataRenderer
    {
        private readonly IDbDataAdapter _DataAdapter;

        public DataRenderer(IDbDataAdapter dataAdapter)
        {
            _DataAdapter = dataAdapter;
        }

        public void Render(TextWriter writer)
        {
            writer.WriteLine("Rendering Data:");
            var dataSet = new DataSet();
            _DataAdapter.Fill(dataSet);
            foreach (DataTable dataTable in dataSet.Tables)
            {
                foreach (DataColumn dataColumn in dataTable.Columns)
                {
                    writer.Write(dataColumn.ColumnName.PadRight(20) + " ");
                }
                writer.WriteLine();
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        writer.Write(dataRow[i].ToString().PadRight(20));
                    }
                    writer.WriteLine();
                }
            }
        }
    }
}
