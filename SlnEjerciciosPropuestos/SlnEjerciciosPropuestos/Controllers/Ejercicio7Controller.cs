using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SlnEjerciciosPropuestos.Models;

namespace SlnEjerciciosPropuestos.Controllers
{
    public class Ejercicio7Controller : Controller
    {
        // GET: Ejercicio7
        public ActionResult Index(ClsEjercicio7 ObjEjercicio7)
        {
            string car = ObjEjercicio7.caracter.ToString();
            int filas = ObjEjercicio7.filas;
            string espacio="";
            ObjEjercicio7.dibujo = new string[filas];
            if(ObjEjercicio7.alineacion == 1)
            {
                for(int i = 0; i < filas; i++)
                {
                    if(i > 0)
                    {
                        ObjEjercicio7.dibujo[i] = ObjEjercicio7.dibujo[i - 1] + car;
                    }
                    else
                    {
                        ObjEjercicio7.dibujo[i] = car;
                    }
                }
            }
            else if(ObjEjercicio7.alineacion == 2)
            {
                for (int i = 0; i < ObjEjercicio7.filas; i++)
                {
                    ObjEjercicio7.dibujo[i] = ObjEjercicio7.dibujo[i] + espacio;
                    for (int j = (filas*2)-1; j > 0; j--)
                    {
                        ObjEjercicio7.dibujo[i] = ObjEjercicio7.dibujo[i] + car;
                    }
                    espacio = espacio + " ";
                    filas = filas - 1;
                }
                Array.Reverse(ObjEjercicio7.dibujo);
            }
            else if(ObjEjercicio7.alineacion == 3)
            {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = filas; j > 0; j--)
                    {
                        if(i >= (j - 1))
                        {
                            ObjEjercicio7.dibujo[i] = ObjEjercicio7.dibujo[i] + car;
                        }
                        else
                        {
                            ObjEjercicio7.dibujo[i] = ObjEjercicio7.dibujo[i] + " ";
                        }
                    }
                }
            }
            return View("Index",ObjEjercicio7);
        }
    }
}