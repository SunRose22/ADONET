using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;

namespace TestInsertTester
{
    using syst;
    [TestClass]
    public class InsertTester
    {
        [TestMethod]
        public void TestInsert()
        {
            string connectionString = "server=localhost; port=3306; username=root; password=girlgurren*22$@piece; database=system_manager";
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            Assert.AreEqual(Program.InsertTester(connection, "Vasili Semonov"), 0);

            connection.Close();
        }
    }
}
