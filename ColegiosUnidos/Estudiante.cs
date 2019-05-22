//Librerias.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegiosUnidos
{
   public class Estudiante
    {
        public string Nombres {get; set;}
        public string Apellidos { get; set; }
        public int Carnet { get; set; }
        public string Email { get; set; }
        public List<Curso> CursosPropios = new List<Curso>();

        public List<double> notasFinales = new List<double>();
        
       //------------------------------------------------
        public int NotasTareas{get; set;}
        public int NotasProyectos{get; set;}
        public int NotasExamenes{get; set;}
       //------------------------------------------------
        public int NotaTareaCurso1 { get; set; }
        public int NotaTareaCurso2 { get; set; }
        public int NotaTareaCurso3 { get; set; }
        public int NotaTareaCurso4 { get; set; }
        public int NotaTareaCurso5 { get; set; }


        public int NotaProyectoCurso1 { get; set; }
        public int NotaProyectoCurso2 { get; set; }
        public int NotaProyectoCurso3 { get; set; }
        public int NotaProyectoCurso4 { get; set; }
        public int NotaProyectoCurso5 { get; set; }

        
       public int NotaExamenCurso1 { get; set; }
        public int NotaExamenCurso2 { get; set; }
        public int NotaExamenCurso3 { get; set; }
        public int NotaExamenCurso4 { get; set; }
        public int NotaExamenCurso5 { get; set; }


        public int NotaFinalCurso1 { get; set; }
        public int NotaFinalCurso2 { get; set; }
        public int NotaFinalCurso3 { get; set; }
        public int NotaFinalCurso4 { get; set; }
        public int NotaFinalCurso5 { get; set; }


        //------------------------------------------------
        public int NotaFinal{get; set;}
        public int PromedioGeneral{get; set;}
        //------------------------------------------------

        //Constructor.
        public Estudiante(string nombre,string apellido, int carnet, string email)
        {
            Nombres = nombre;
            Apellidos = apellido;
            Carnet = carnet;
            Email = email;
        }
    }
}
