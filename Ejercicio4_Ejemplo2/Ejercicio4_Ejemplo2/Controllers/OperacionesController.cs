using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio4_Ejemplo2.Controllers
{
    public class OperacionesController : Controller
    {
        // GET: Operaciones
        public ActionResult Index()
        {
            return View();
        }
        public static int Suma(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
   
        public static int MRUespacio(double tiempo, double velocidad)
        {
            int result;
            double espacio;
            espacio = velocidad * tiempo;
            result = Convert.ToInt32(espacio);
            return result;
        }
        public static int Division(int dividendo, int divisor)
        {
            /*if(divisor == 0)
                trown new DividellyZeroException("No se puede dividir por 0");*/
            return dividendo / divisor;
        }
    }
}