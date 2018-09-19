using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaU1_ejercicio01.Models
{
    public class ClsConcursoProyectos
    {
        public string CategoriaProyecto { get; set; }
        public string TemaProyecto { get; set; }
        public string IntegrantesProyecto { get; set; }
        public string Curso { get; set; }
        public string DocenteCurso { get; set; }
    }



    public class ClsListaProyectos
    {
        public static List<ClsConcursoProyectos> proyectos = new List<ClsConcursoProyectos>();
    }
}