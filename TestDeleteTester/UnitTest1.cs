using Microsoft.VisualStudio.TestTools.UnitTesting;
using syst;
using System;
using System.Data.SqlClient;
using System.Configuration;
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
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            Assert.AreEqual(Program.DeleteTester(connection, 8), 0);
            connection.Close();
        }
    }
}
