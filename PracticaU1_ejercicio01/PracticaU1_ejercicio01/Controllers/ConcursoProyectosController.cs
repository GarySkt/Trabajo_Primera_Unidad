using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticaU1_ejercicio01.Models;

namespace PracticaU1_ejercicio01.Controllers
{
    public class ConcursoProyectosController : Controller
    { 
        // GET: ConsursoProyectos
        public ActionResult IndexConcursoProyectos(ClsConcursoProyectos obj)
        { 
            return View();
        }

        public ActionResult agregar(ClsListaProyectos listaProyectos,ClsConcursoProyectos obj)
        {
            obj.CategoriaProyecto = Convert.ToString(Request.Form["CategoriaProyecto"]);
            obj.TemaProyecto = Convert.ToString(Request.Form["TemaProyecto"]);
            obj.IntegrantesProyecto = Convert.ToString(Request.Form["IntegrantesProyecto"]);
            obj.Curso = Convert.ToString(Request.Form["Curso"]);
            obj.DocenteCurso = Convert.ToString(Request.Form["DocenteCurso"]);
  
            ClsListaProyectos.proyectos.Add(obj);
            
            return View("IndexConcursoProyectos", ClsListaProyectos.proyectos.ToList());
        }


        //METODO PARA SORTEAR
        public ActionResult sortear(ClsListaProyectos listaProyectos, ClsConcursoProyectos obj)
        {
            if(ClsListaProyectos.proyectos.Count>0)
            {
                List<ClsConcursoProyectos> sorteo = ClsListaProyectos.proyectos;
                var rnd = new Random();
                var result = sorteo.OrderBy(item => rnd.Next());
                sorteo = result.ToList();

                ClsListaProyectos.proyectos = sorteo;
            }
            return View("IndexConcursoProyectos", ClsListaProyectos.proyectos.ToList());
        }
    }
}