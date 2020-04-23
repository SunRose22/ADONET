using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using syst;
using System.Data.SqlClient;
using System.Data.Common;

namespace TestSelectTester
{
    using syst;
    [TestClass]
    public class SelectTester
    {
        [TestMethod]
        public void SelectGalina()
        {
            string connectionString = "server=localhost; port=3306; username=root; password=girlgurren*22$@piece; database=system_manager_test";
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            Assert.AreEqual(Program.SelectTesterByName(connection, "Galina Ermak"), 0);
            connection.Close();
        }
    }
}
