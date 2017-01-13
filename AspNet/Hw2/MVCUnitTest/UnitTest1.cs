using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MVCUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Hw2.Models.Customer t1 = new Hw2.Models.Customer() { nombre = " ella", apellido = "simpson", edad = 3 };
            Hw2.Controllers.CustomerController c1 = new Hw2.Controllers.CustomerController();
            var result = Hw2.Controllers.CustomerController.c1.DisplayCustomer(t1) as System.Web.Mvc.ViewResult;
           
            Assert.AreEqual("DisplayCustomer", result);
            
           

        }
        
    }
}
