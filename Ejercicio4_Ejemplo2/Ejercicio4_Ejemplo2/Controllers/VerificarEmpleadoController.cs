using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio4_Ejemplo2.Controllers
{
    public class VerificarEmpleadoController : Controller
    {
        // GET: VerificarEmpleado
        public class checkEmployee
        {
            public virtual Boolean checkEmp()
            {
                throw new NotImplementedException();
            }
        }

        public class processEmployee
        {
            public Boolean insertEmployee(checkEmployee objtmp)
            {
                objtmp.checkEmp();
                return true;
            }
        }
    }
}