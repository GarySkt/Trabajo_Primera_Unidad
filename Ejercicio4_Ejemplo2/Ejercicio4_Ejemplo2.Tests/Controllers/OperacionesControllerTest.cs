using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using Ejercicio4_Ejemplo2.Controllers;

namespace Ejercicio4_Ejemplo2.Tests.Controllers
{
    [TestClass]
    public class OperacionesControllerTest
    {
        [TestMethod]
        public void Suma_CorroboracionOperacionSuma_ReturnResultadoEsperado()
        {
            //arrange
            const int A = 3;
            const int B = 4;
            const int ResultadoEsperado = 7;

            //act
            var actual = OperacionesController.Suma(A, B);

            //assert
            Assert.AreEqual(ResultadoEsperado, actual);
        }
        [TestMethod]
        public void MRUespacio_CorroboracionOperacionMRU_ReturnResultadoEsperado()
        {
            //arrange
            const double V = 4.5;
            const double T = 2;
            const double ResultadoEsperado = 9;

            //act
            var actual = OperacionesController.MRUespacio(V, T);

            //assert
            Assert.AreEqual(ResultadoEsperado, actual);
        }
    }
}