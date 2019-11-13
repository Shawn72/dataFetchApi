using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataFetchAPI;
using DataFetchAPI.Controllers;

namespace DataFetchAPI.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
      
        [TestMethod]
        public void GetById()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
          //  string result = controller.Get(5);

            // Assert
          //  Assert.AreEqual("value", result);
        }
        
        [TestMethod]
        public void Put()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
          //controller.Put(5, "value");

           // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
          //  controller.Delete(5);

            // Assert
        }
    }
}
