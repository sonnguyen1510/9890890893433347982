using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bán_Hàng_Onl_WebForm.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bán_Hàng_Onl_WebForm.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            int a = 4;
            int b = 4;
            Assert.IsTrue(a == b, "Test Sucessful");
        }

        [TestMethod()]
        public void AboutTest()
        {
            int a = 4;
            int b = 5;
            Assert.IsTrue(a == b, "Test Fail");
        }

        [TestMethod()]
        public void ContactTest()
        {
            int a = 4;
            int b = 5;
            Assert.IsTrue(a == b, "Test Fail");
        }
    }
}