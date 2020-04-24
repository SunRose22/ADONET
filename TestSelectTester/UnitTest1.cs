using Microsoft.VisualStudio.TestTools.UnitTesting;
using syst;
using System;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;


namespace TestSelectTester
{
    using syst;
    [TestClass]
    public class SelectTester
    {
        [TestMethod]
        public void TestSelect()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            Assert.AreEqual(Program.SelectTesterByName(connection, "Galina Ermak"), 0);
            connection.Close();
        }
    }
}
