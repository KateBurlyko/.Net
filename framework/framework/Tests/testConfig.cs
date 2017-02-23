using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.Tests
{
    [TestFixture]
    class testConfig
    {
        [Test]
        public static void test()
        {
            string qwe = ConfigurationManager.AppSettings["chrome"];
        }

    }
}
