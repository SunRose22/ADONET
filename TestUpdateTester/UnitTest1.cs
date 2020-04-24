using Microsoft.VisualStudio.TestTools.UnitTesting;
using syst;
using System;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace TestUpdateTester
{
    using syst;
    [TestClass]
    public class UpdateTester
    {
        [TestMethod]
        public void TestUpdate()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            Assert.AreEqual(Program.UpdateTesterById(connection, 7, "Vasili Semov"), 0);
            connection.Close();
        }
    }
}
