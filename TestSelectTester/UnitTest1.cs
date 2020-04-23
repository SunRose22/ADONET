using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using syst;
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
            string connectionString = "server=localhost; port=3306; username=root; password=girlgurren*22$@piece; database=system_manager";
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            Assert.AreEqual(Program.SelectTesterByName(connection, "Galina Ermak"), 0);
            connection.Close();
        }
    }
}
