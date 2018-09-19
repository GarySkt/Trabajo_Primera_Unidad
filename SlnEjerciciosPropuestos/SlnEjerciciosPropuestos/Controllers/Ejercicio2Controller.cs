using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SlnEjerciciosPropuestos.Models;

namespace SlnEjerciciosPropuestos.Controllers
{
    public class Ejercicio2Controller : Controller
    {
        // GET: Ejercicio2
        public ActionResult Index2(ClsEjercicio2 ObjEjercicio2)
        {
            int con1 = 0, con2 = 0;
            for (int i = 0; i < 10; i++)
            {
                if (ObjEjercicio2.arraynum[i] < 0)
                {
                    con1++;
                }
                else
                {
                    con2++;
                }
            }

            ObjEjercicio2.arrayneg = new int[con1];
            ObjEjercicio2.arraypos = new int[con2];
            con1 = 0;
            con2 = 0;

            for (int i = 0; i < 10; i++)
            {
                if(ObjEjercicio2 != null)
                {
                    if (ObjEjercicio2.arraynum[i] < 0)
                    {
                        ObjEjercicio2.arrayneg[con1] = ObjEjercicio2.arraynum[i];
                        con1++;
                    }
                    else
                    {
                        ObjEjercicio2.arraypos[con2] = ObjEjercicio2.arraynum[i];
                        con2++;
                    }
                }                
            }
            return View("Index",ObjEjercicio2);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}