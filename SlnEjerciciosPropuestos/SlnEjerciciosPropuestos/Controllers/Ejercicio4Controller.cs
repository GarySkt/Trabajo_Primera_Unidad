using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SlnEjerciciosPropuestos.Models;

namespace SlnEjerciciosPropuestos.Controllers
{
    public class Ejercicio4Controller : Controller
    {
        // GET: Ejercicio4
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2(ClsEjercicio4 ObjEjercicio4)
        {
            ObjEjercicio4.nums = new int[ObjEjercicio4.cantnum];
            Random rand = new Random();
            for(int i = 0; i < ObjEjercicio4.cantnum; i++)
            {
                ObjEjercicio4.nums[i] = rand.Next(1, 1000);
            }
            Array.Sort(ObjEjercicio4.nums);
            ObjEjercicio4.mayor = ObjEjercicio4.nums[(ObjEjercicio4.cantnum-1)];
            ObjEjercicio4.menor = ObjEjercicio4.nums[0];
            ObjEjercicio4.suma = ObjEjercicio4.nums.Sum();
            ObjEjercicio4.promedio = ObjEjercicio4.suma / ObjEjercicio4.cantnum;
            return View("Index",ObjEjercicio4);
        }
    }
}