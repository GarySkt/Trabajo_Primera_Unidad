using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SlnEjerciciosPropuestos.Models;

namespace SlnEjerciciosPropuestos.Controllers
{
    public class Ejercicio11Controller : Controller
    {
        // GET: Ejercicio11
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2(ClsEjercicio11 ObjEjercicio11)
        {
            ObjEjercicio11.cadenas = new List<string>();
            int cont = 2;
            String cad = "";
            for(int i = 0; i < cont ; i++)
            {
                if(ObjEjercicio11.numero == 1)
                {
                    ObjEjercicio11.cadenas.Add(ObjEjercicio11.caracter.ToString());
                }
                else if (ObjEjercicio11.numero % 2 == 0)
                {
                    cad = "";
                    for(int x = 0; x < ObjEjercicio11.numero; x++)
                    {
                        cad = cad + ObjEjercicio11.caracter.ToString();
                    }
                    ObjEjercicio11.cadenas.Add(cad);
                    ObjEjercicio11.numero = ObjEjercicio11.numero / 2;
                    cont++;
                }
                else
                {
                    cad = "";
                    for(int y = 0; y < ObjEjercicio11.numero; y++)
                    {
                        cad = cad + ObjEjercicio11.caracter.ToString();
                    }
                    ObjEjercicio11.cadenas.Add(cad);
                    ObjEjercicio11.numero = (ObjEjercicio11.numero * 3) + 1;
                    cont++;
                }
            }
            return View("Index",ObjEjercicio11);
        }
    }
}