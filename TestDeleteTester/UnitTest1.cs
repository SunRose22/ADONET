using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;

namespace TestDeleteTester
{
    using syst;
    [TestClass]
    public class DeleteTester
    {
        [TestMethod]
        public void TestDelete()
        {
            string connectionString = "server=localhost; port=3306; username=root; password=girlgurren*22$@piece; database=system_manager";
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            Assert.AreEqual(Program.DeleteTester(connection, 8), 0);
            connection.Close();
        }
    }
}
