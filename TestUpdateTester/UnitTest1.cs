using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            string connectionString = "server=localhost; port=3306; username=root; password=girlgurren*22$@piece; database=system_manager";
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            Assert.AreEqual(Program.UpdateTesterById(connection, 7, "Vasili Semov"), 0);
            connection.Close();
        }
    }
}
