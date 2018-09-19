using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SlnEjerciciosPropuestos.Models;

namespace SlnEjerciciosPropuestos.Controllers
{
    public class Ejercicio9Controller : Controller
    {
        // GET: Ejercicio9
        public ActionResult Index(ClsEjercicio9 ObjEjercicio9)
        {
            if (ObjEjercicio9.monto2 >= 0)
            {
                ObjEjercicio9.monto = Convert.ToInt32(Math.Floor(ObjEjercicio9.monto2));

                ObjEjercicio9.b100 = ObjEjercicio9.monto / 100;
                ObjEjercicio9.b50 = ObjEjercicio9.monto % 100 / 50;
                ObjEjercicio9.b20 = ObjEjercicio9.monto % 100 % 50 / 20;
                ObjEjercicio9.b10 = ObjEjercicio9.monto % 100 % 50 % 20 / 10;

                ObjEjercicio9.cantidad = ObjEjercicio9.b100 + ObjEjercicio9.b50 + ObjEjercicio9.b20 + ObjEjercicio9.b10;
            }
            else
            {
                Response.Write("<script language=javascript>alert('Ingrese monto correcto.');</script>");
            }
            return View("Index",ObjEjercicio9);
        }
    }
}