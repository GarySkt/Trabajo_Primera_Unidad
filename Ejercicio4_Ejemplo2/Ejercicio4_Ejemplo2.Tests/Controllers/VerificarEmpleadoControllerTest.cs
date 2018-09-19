using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using static Ejercicio4_Ejemplo2.Controllers.VerificarEmpleadoController;

namespace Ejercicio4_Ejemplo2.Tests.Controllers
{
    [TestClass]
    public class VerificarEmpleadoControllerTest
    {
        [TestMethod]
        public void VerificarEmpleado_ConfigurarObjetoSimulado_ReturnTrue()
        {
            //arrange
            //esta es la magia del mock
            processEmployee objProcessEmployee = new processEmployee();
            Mock<checkEmployee> chk = new Mock<checkEmployee>();

            //act
            chk.Setup(x => x.checkEmp()).Returns(true);
            
            //assert
            Assert.AreEqual(objProcessEmployee.insertEmployee(chk.Object), true);
        }
    }
}
