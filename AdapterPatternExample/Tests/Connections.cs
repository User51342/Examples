using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdapterPatternExample.Tests
{
    [TestClass]
   public class Connections
    {
        [TestMethod]
        public void SqlClientConnection()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
            try
            {
                con.Open();
                con.Close();
                Console.WriteLine("Successful");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [TestMethod]
        public void OleDBConnection()
        {
            var conString = ConfigurationManager.ConnectionStrings["AdapterPatternExampleDatabase"].ConnectionString;
            var con = new OleDbConnection(conString);
            var sqlString = new OleDbCommand("SELECT * FROM Patterns");
            var adapter = new OleDbDataAdapter();
            adapter.SelectCommand = sqlString;
            adapter.SelectCommand.Connection = new OleDbConnection(conString);
            DataSet dataset = new DataSet();
            con.Open();
       adapter.Fill(dataset);
            con.Close();
            Console.WriteLine("Successful");
        }

        [TestMethod]
        public void SqlDataAdapter()
        {
            var conString = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
            var sqlString = "SELECT * FROM Patterns";
            var adapter = new SqlDataAdapter(sqlString,conString);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
        }
    }
}
