using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SlnEjerciciosPropuestos.Models;

namespace SlnEjerciciosPropuestos.Controllers
{
    public class Ejercicio3Controller : Controller
    {
        // GET: Ejercicio3
        public ActionResult Index2(ClsEjercicio3 ObjEjercicio3)
        {
            int con1 = 0, con2 = 0, con11 = 0, con21 = 0;
            for (int i = 0; i < 10; i++)
            {
                if (ObjEjercicio3.arraynum[i] % 2 == 0)
                {
                    con11++;
                }
                else
                {
                    con21++;
                }
            }
            if(con21 == 0)
            {
                con21 = 1;
            }
            if(con11 == 0)
            {
                con11 = 1;
            }

            ObjEjercicio3.arraypar= new int[con11];
            ObjEjercicio3.arrayimpar = new int[con21];

            for (int i = 0; i < 10; i++)
            {
                if(ObjEjercicio3 != null)
                {
                    if (ObjEjercicio3.arraynum[i] %2 == 0)
                    {
                        ObjEjercicio3.arraypar[con1] = ObjEjercicio3.arraynum[i];
                        con1++;
                    }
                    else
                    {
                        ObjEjercicio3.arrayimpar[con2] = ObjEjercicio3.arraynum[i];
                        con2++;
                    }
                }                
            }

            ObjEjercicio3.mediapar = ObjEjercicio3.arraypar.Sum() / con11;
            ObjEjercicio3.mediaimpar = ObjEjercicio3.arrayimpar.Sum() / con21;

            return View("Index",ObjEjercicio3);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}