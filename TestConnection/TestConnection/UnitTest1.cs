using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using syst;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TestConnection
{
    using syst;
    [TestClass]
    public class TestConnection
    {
        [TestMethod]
        public void TestConnect()
        {
            Assert.AreEqual(Program.Connection(), 0);
        }
    }
}
