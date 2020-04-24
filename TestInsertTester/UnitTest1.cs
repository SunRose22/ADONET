using Microsoft.VisualStudio.TestTools.UnitTesting;
using syst;
using System;
using System.Data.SqlClient;
using System.Configuration;
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
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            Assert.AreEqual(Program.InsertTester(connection, "Vasili Semonov"), 0);

            connection.Close();
        }
    }
}
