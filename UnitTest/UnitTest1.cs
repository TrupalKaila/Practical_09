using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practical_Test3.Controllers;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HomeController homeController = new HomeController();
            var str = homeController.Test3();
            Assert.AreEqual("Hello World", str);
        }
    }
}
