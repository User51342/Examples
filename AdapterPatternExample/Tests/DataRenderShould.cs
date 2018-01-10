using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPatternExample.Adapter;
using AdapterPatternExample.Models;
using AdapterPatternExample.Renderer;

namespace AdapterPatternExample.Tests
{
    [TestClass]
    public class DataRenderShould
    {
        [TestMethod]
        public void Souldbe4Lines()
        {
            DataRenderer dataRenderer = new DataRenderer(new StubDBDataAdabter());
            var textWriter = new StringWriter();
            dataRenderer.Render(textWriter);
            var result = textWriter.ToString();
            Console.Write(result);
            Assert.AreEqual(3, result.Count(x => x == '\n'));

        }

        [TestMethod]
        public void UseSqlDataAdapter()
        {
            var conString = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
            var sqlString = "SELECT * FROM Patterns";
            var adapter = new SqlDataAdapter(sqlString, conString);
            var textWriter = new StringWriter();
            DataRenderer renderer = new DataRenderer(adapter);
            renderer.Render(textWriter);
            var result = textWriter.ToString();
            Console.Write(result);
            Assert.AreEqual(4, result.Count(x => x == '\n'));
        }

        [TestMethod]
        public void UseDataPetternAdapter()
        {
            var patterns = new List<Pattern>();
            patterns.Add(new Pattern() { Id = 1, Name = "MyFirst", Description = "My first description" });
            patterns.Add(new Pattern() { Id = 2, Name = "MySecond", Description = "My second description" });
            PatternRenderer adapter = new PatternRenderer();
            var result = adapter.ListPatterns(patterns);
            Assert.AreEqual(4, result.Count(x => x == '\n'));
        }

        [TestMethod]
        public void Date12()
        {
            var newd = new DateTime(2018,04,01);
            Console.WriteLine(newd.AddDays(-84));
        }
    }


}
