using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SlnEjerciciosPropuestos.Models;

namespace SlnEjerciciosPropuestos.Controllers
{
    public class Ejercicio6Controller : Controller
    {
        // GET: Ejercicio6
        public ActionResult Index(ClsEjercicio6 ObjEjercicio6)
        {
            if(ObjEjercicio6.tipoauto == 1)
            {
                ObjEjercicio6.monto = (ObjEjercicio6.dias * 15) + (ObjEjercicio6.kms * 20);
            }
            else if(ObjEjercicio6.tipoauto == 2)
            {
                ObjEjercicio6.monto = (ObjEjercicio6.dias * 20) + (ObjEjercicio6.kms * 30);
            }
            else
            {
                ObjEjercicio6.monto = (ObjEjercicio6.dias * 30) + (ObjEjercicio6.kms * 40);
            }

            return View("Index",ObjEjercicio6);
        }
    }
}