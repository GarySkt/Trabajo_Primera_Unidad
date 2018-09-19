using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejercicio4_Ejemplo2.Models;

namespace Ejercicio4_Ejemplo2.Controllers
{
    public class VentaController : Controller
    {
        // GET: Ventas
        public static
        double precioUSB = 120;
        double precioMOUSE = 50;
        double precioTECLADO = 85;
        double precioDISCODURO = 350;

        // GET: venta
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalcularVenta(ClsVentas objventa)
        {
            //ClsVentas objVenta = new ClsVentas();         //esto es igual a la intacion de arriba
            if (objventa.productoUSB == true)
            {
                objventa.subtotal = objventa.subtotal + precioUSB;
            }
            if (objventa.productoMOUSE == true)
            {
                objventa.subtotal = objventa.subtotal + precioMOUSE;
            }
            if (objventa.productoTECLADO == true)
            {
                objventa.subtotal = objventa.subtotal + precioTECLADO;
            }
            if (objventa.productoDISCODURO == true)
            {
                objventa.subtotal = objventa.subtotal + precioDISCODURO;
            }

            objventa.igv = objventa.subtotal * 0.18;
            objventa.total = objventa.subtotal + objventa.igv;

            return View("CalcularVenta", objventa);

        }
    }
}