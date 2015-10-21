using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrabalhoFinalASW.Controllers;
using System.Web.Http.Results;
using System.Collections.Generic;

namespace TrabalhoFinalASW.Tests
{
    [TestClass]
    public class NotasTest
    {
        [TestMethod]
        public void GET()
        {
            //// Arrange
            NotasController controller = new NotasController();

            //// Act
            var result = controller.Get();
            //ViewResult result = controller.Index() as ViewResult;

            //// Assert
            Assert.IsInstanceOfType(result, typeof(OkNegotiatedContentResult<List<TrabalhoFinalASW.Controllers.Notas>>));

            Assert.IsTrue(1 == 2, "Um não é igual a um");
        }
    }
}
