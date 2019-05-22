//Indice.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColegiosUnidos
{
    public partial class Consulta_Informacion : Form
    {
        //Constructor.
        Admin InfoAdmin;
        public Consulta_Informacion(Admin Admin0)
        {
            InitializeComponent();
            InfoAdmin = Admin0;

            //Fondos.
            BTN_regresar.Image = InfoAdmin.InfoLogin.listaImg[2];
            this.BackgroundImage = InfoAdmin.InfoLogin.listaImg[3];
            this.Opacity = 0.95;
        }

        //Boton regresar.
        private void BTN_regresar_Click(object sender, EventArgs e)
        {
            //InfoAdmin.CursosIngresados = cursosIngresados;
            InfoAdmin.Show();
            this.Hide();
        }

        //Control del indice propiedad.
        private int indicePropiedad;
        private void CB_propiedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            indicePropiedad = CB_propiedad.SelectedIndex;
        }

        //Control del indice metodo.
        private int indiceMetodo;
        private void CB_metodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceMetodo = CB_metodo.SelectedIndex;
        }

        //Control del indice tipo.
        private int indiceTipo;
        private void CB_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceTipo = CB_tipo.SelectedIndex;
        }




        //Boton ordenar.
        private void BTN_ok_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < InfoAdmin.AlumnosIngresados; i++)
            {
                /*
                for (int j = 0; j < InfoAdmin.CursosIngresados; j++)
                {
                    int preFinalTareas = Convert.ToInt32(InfoAdmin.Estudiantes[i].CursosPropios[j].AC[0].calcular_preNotaFinal()); //Tareas.
                    int preFinalProyectos = Convert.ToInt32(InfoAdmin.Estudiantes[i].CursosPropios[j].AC[1].calcular_preNotaFinal()); //Proyectos.
                    int preFinalExamenes = Convert.ToInt32(InfoAdmin.Estudiantes[i].CursosPropios[j].AC[2].calcular_preNotaFinal()); //Examenes.

                    //Oficial.

                    //Por si acaso.
                    InfoAdmin.Estudiantes[i].CursosPropios[j].notaFinal = preFinalTareas + preFinalProyectos + preFinalExamenes;

                    InfoAdmin.Estudiantes[i].notasFinales.Add(InfoAdmin.Estudiantes[i].CursosPropios[j].notaFinal);



                }
                InfoAdmin.Estudiantes[i].NotasTareas = Convert.ToInt32(InfoAdmin.Estudiantes[i].notasFinales[0]);
                InfoAdmin.Estudiantes[i].NotasProyectos = Convert.ToInt32(InfoAdmin.Estudiantes[i].notasFinales[1]);
                InfoAdmin.Estudiantes[i].NotasExamenes = Convert.ToInt32(InfoAdmin.Estudiantes[i].notasFinales[2]);
                for (int k = 0; k < InfoAdmin.Estudiantes[i].notasFinales.Count(); k++)
                {
                    InfoAdmin.Estudiantes[i].NotaFinal += Convert.ToInt32(InfoAdmin.Estudiantes[i].notasFinales[k]);
                }
                */

                int cont = 0;
                try
                {
                    InfoAdmin.Estudiantes[i].NotaTareaCurso1 = Convert.ToInt32(InfoAdmin.Estudiantes[i].CursosPropios[0].AC[0].calcular_preNotaFinal());
                    InfoAdmin.Estudiantes[i].NotaProyectoCurso1 = Convert.ToInt32(InfoAdmin.Estudiantes[i].CursosPropios[0].AC[1].calcular_preNotaFinal());
                    InfoAdmin.Estudiantes[i].NotaExamenCurso1 = Convert.ToInt32(InfoAdmin.Estudiantes[i].CursosPropios[0].AC[2].calcular_preNotaFinal());

                    InfoAdmin.Estudiantes[i].NotaFinalCurso1 = InfoAdmin.Estudiantes[i].NotaTareaCurso1 + InfoAdmin.Estudiantes[i].NotaProyectoCurso1+InfoAdmin.Estudiantes[i].NotaExamenCurso1;
                cont++;
                }
                catch { }

                try
                {
                    InfoAdmin.Estudiantes[i].NotaTareaCurso2 = Convert.ToInt32(InfoAdmin.Estudiantes[i].CursosPropios[1].AC[0].calcular_preNotaFinal());
                    InfoAdmin.Estudiantes[i].NotaProyectoCurso2 = Convert.ToInt32(InfoAdmin.Estudiantes[i].CursosPropios[1].AC[1].calcular_preNotaFinal());
                    InfoAdmin.Estudiantes[i].NotaExamenCurso2 = Convert.ToInt32(InfoAdmin.Estudiantes[i].CursosPropios[1].AC[2].calcular_preNotaFinal());
                    
                    InfoAdmin.Estudiantes[i].NotaFinalCurso2 = InfoAdmin.Estudiantes[i].NotaTareaCurso2 + InfoAdmin.Estudiantes[i].NotaProyectoCurso2+InfoAdmin.Estudiantes[i].NotaExamenCurso2;
                    cont++;
                }
                catch { }

                try
                {
                    InfoAdmin.Estudiantes[i].NotaTareaCurso3 = Convert.ToInt32(InfoAdmin.Estudiantes[i].CursosPropios[2].AC[0].calcular_preNotaFinal());
                    InfoAdmin.Estudiantes[i].NotaProyectoCurso3 = Convert.ToInt32(InfoAdmin.Estudiantes[i].CursosPropios[2].AC[1].calcular_preNotaFinal());
                    InfoAdmin.Estudiantes[i].NotaExamenCurso3 = Convert.ToInt32(InfoAdmin.Estudiantes[i].CursosPropios[2].AC[2].calcular_preNotaFinal());

                    InfoAdmin.Estudiantes[i].NotaFinalCurso3 = InfoAdmin.Estudiantes[i].NotaTareaCurso3 + InfoAdmin.Estudiantes[i].NotaProyectoCurso3+InfoAdmin.Estudiantes[i].NotaExamenCurso3;
                    cont++;
                }
                catch { }

                try
                {
                    InfoAdmin.Estudiantes[i].NotaTareaCurso4 = Convert.ToInt32(InfoAdmin.Estudiantes[i].CursosPropios[3].AC[0].calcular_preNotaFinal());
                    InfoAdmin.Estudiantes[i].NotaProyectoCurso4 = Convert.ToInt32(InfoAdmin.Estudiantes[i].CursosPropios[3].AC[1].calcular_preNotaFinal());
                    InfoAdmin.Estudiantes[i].NotaExamenCurso4 = Convert.ToInt32(InfoAdmin.Estudiantes[i].CursosPropios[3].AC[2].calcular_preNotaFinal());

                    InfoAdmin.Estudiantes[i].NotaFinalCurso4 = InfoAdmin.Estudiantes[i].NotaTareaCurso4 + InfoAdmin.Estudiantes[i].NotaProyectoCurso4 + InfoAdmin.Estudiantes[i].NotaExamenCurso4;
                    cont++;
                }
                catch { }

                try
                {
                    InfoAdmin.Estudiantes[i].NotaTareaCurso5 = Convert.ToInt32(InfoAdmin.Estudiantes[i].CursosPropios[4].AC[0].calcular_preNotaFinal());
                    InfoAdmin.Estudiantes[i].NotaProyectoCurso5 = Convert.ToInt32(InfoAdmin.Estudiantes[i].CursosPropios[4].AC[1].calcular_preNotaFinal());
                    InfoAdmin.Estudiantes[i].NotaExamenCurso5 = Convert.ToInt32(InfoAdmin.Estudiantes[i].CursosPropios[4].AC[2].calcular_preNotaFinal());

                    InfoAdmin.Estudiantes[i].NotaFinalCurso5 = InfoAdmin.Estudiantes[i].NotaTareaCurso5 + InfoAdmin.Estudiantes[i].NotaProyectoCurso5 + InfoAdmin.Estudiantes[i].NotaExamenCurso5;
                    cont++;
                }
                catch { }

                //Oficial.
                InfoAdmin.Estudiantes[i].PromedioGeneral = (InfoAdmin.Estudiantes[i].NotaFinalCurso1 + InfoAdmin.Estudiantes[i].NotaFinalCurso2 + InfoAdmin.Estudiantes[i].NotaFinalCurso3 + InfoAdmin.Estudiantes[i].NotaFinalCurso4 + InfoAdmin.Estudiantes[i].NotaFinalCurso5) / cont;

                //Por si acaso.
                //InfoAdmin.Estudiantes[i].PromedioGeneral = Convert.ToInt32(InfoAdmin.Estudiantes[i].NotaFinal) / InfoAdmin.Estudiantes[i].notasFinales.Count();
            }

            Ordenamientos.asignaciones = 0;
            Ordenamientos.comparaciones = 0;
            DGV_consultaOrdenada.Rows.Clear();
            for (int i = 0; i < InfoAdmin.AlumnosIngresados; i++)
            {
                DGV_consultaOrdenada.Rows.Add();
            }

            string Parametro = CB_propiedad.Text;
            if (CB_propiedad.Text == "Notas de Tareas")
            {
                Parametro = "Tareas";
            }
            string Metodo = CB_metodo.Text;
            string STipo = CB_tipo.Text;
            bool Tipo;

            if (STipo == "Ascendente")
            {
                Tipo = true;
            }
            else
            {
                Tipo = false;
            }

            switch (Metodo)
            {
                case "Burbuja":
                    InfoAdmin.EstudiantesOrdenados.Clear();
                    InfoAdmin.EstudiantesOrdenados.AddRange(Ordenamientos.Burbuja(InfoAdmin.Estudiantes, Parametro, Tipo));
                    InfoAdmin.Estudiantes.Clear();
                    InfoAdmin.Estudiantes.AddRange(InfoAdmin.EstudiantesOrdenados);
                    L_comparaciones.Text = "Comparaciones: " + Ordenamientos.comparaciones.ToString();
                    L_asignaciones.Text = "Asignaciones:" + Ordenamientos.asignaciones.ToString();
                    break;

                case "Insercion":
                    InfoAdmin.EstudiantesOrdenados.Clear();
                    InfoAdmin.EstudiantesOrdenados.AddRange(Ordenamientos.Insercion(InfoAdmin.Estudiantes, Parametro, Tipo));
                    InfoAdmin.Estudiantes.Clear();
                    InfoAdmin.Estudiantes.AddRange(InfoAdmin.EstudiantesOrdenados);
                    L_comparaciones.Text = "Comparaciones: " + Ordenamientos.comparaciones.ToString();
                    L_asignaciones.Text = "Asignaciones:" + Ordenamientos.asignaciones.ToString();
                    break;
                case "Seleccion":
                    InfoAdmin.EstudiantesOrdenados.Clear();
                    InfoAdmin.EstudiantesOrdenados.AddRange(Ordenamientos.Seleccion(InfoAdmin.Estudiantes, Parametro, Tipo));
                    InfoAdmin.Estudiantes.Clear();
                    InfoAdmin.Estudiantes.AddRange(InfoAdmin.EstudiantesOrdenados);
                    L_comparaciones.Text = "Comparaciones: " + Ordenamientos.comparaciones.ToString();
                    L_asignaciones.Text = "Asignaciones:" + Ordenamientos.asignaciones.ToString();
                    break;
                case "Shell":
                    InfoAdmin.EstudiantesOrdenados.Clear();
                    InfoAdmin.EstudiantesOrdenados.AddRange(Ordenamientos.Shell(InfoAdmin.Estudiantes, Parametro, Tipo));
                    InfoAdmin.Estudiantes.Clear();
                    InfoAdmin.Estudiantes.AddRange(InfoAdmin.EstudiantesOrdenados);
                    L_comparaciones.Text = "Comparaciones: " + Ordenamientos.comparaciones.ToString();
                    L_asignaciones.Text = "Asignaciones:" + Ordenamientos.asignaciones.ToString();
                    break;
                case "Quick":
                    InfoAdmin.EstudiantesOrdenados.Clear();
                    InfoAdmin.EstudiantesOrdenados.AddRange(Ordenamientos.Quick(InfoAdmin.Estudiantes,0,InfoAdmin.Estudiantes.Count()-1, Parametro, Tipo));
                    InfoAdmin.Estudiantes.Clear();
                    InfoAdmin.Estudiantes.AddRange(InfoAdmin.EstudiantesOrdenados);
                    L_comparaciones.Text = "Comparaciones: " + Ordenamientos.comparaciones.ToString();
                    L_asignaciones.Text = "Asignaciones:" + Ordenamientos.asignaciones.ToString();
                    break;
                case "Mezcla":
                    InfoAdmin.EstudiantesOrdenados.Clear();
                    InfoAdmin.EstudiantesOrdenados.AddRange(Ordenamientos.Mezcla(InfoAdmin.Estudiantes.ToArray(), 0, InfoAdmin.Estudiantes.Count() - 1, Parametro, Tipo));
                    InfoAdmin.Estudiantes.Clear();
                    InfoAdmin.Estudiantes.AddRange(InfoAdmin.EstudiantesOrdenados);
                    L_comparaciones.Text = "Comparaciones: " + Ordenamientos.comparaciones.ToString();
                    L_asignaciones.Text = "Asignaciones:" + Ordenamientos.asignaciones.ToString();
                    break;
                default:
                    MessageBox.Show("Defina la consulta correctamente", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            for (int i = 0; i < InfoAdmin.AlumnosIngresados; i++)
            {
                DGV_consultaOrdenada.Rows[i].Cells[0].Value = InfoAdmin.Estudiantes[i].Nombres;
                DGV_consultaOrdenada.Rows[i].Cells[1].Value = InfoAdmin.Estudiantes[i].Apellidos;
                DGV_consultaOrdenada.Rows[i].Cells[2].Value = InfoAdmin.Estudiantes[i].Carnet;
                DGV_consultaOrdenada.Rows[i].Cells[3].Value = InfoAdmin.Estudiantes[i].Email;

                try
                {
                    DGV_consultaOrdenada.Rows[i].Cells[4].Value = InfoAdmin.Estudiantes[i].NotaTareaCurso1;
                    DGV_consultaOrdenada.Rows[i].Cells[5].Value = InfoAdmin.Estudiantes[i].NotaProyectoCurso1;
                    DGV_consultaOrdenada.Rows[i].Cells[6].Value = InfoAdmin.Estudiantes[i].NotaExamenCurso1;
                    DGV_consultaOrdenada.Rows[i].Cells[7].Value = InfoAdmin.Estudiantes[i].NotaFinalCurso1;
                    }
                catch {}

                try
                {
                    DGV_consultaOrdenada.Rows[i].Cells[8].Value = InfoAdmin.Estudiantes[i].NotaTareaCurso2;
                    DGV_consultaOrdenada.Rows[i].Cells[9].Value = InfoAdmin.Estudiantes[i].NotaProyectoCurso2;
                    DGV_consultaOrdenada.Rows[i].Cells[10].Value = InfoAdmin.Estudiantes[i].NotaExamenCurso2;
                    DGV_consultaOrdenada.Rows[i].Cells[11].Value = InfoAdmin.Estudiantes[i].NotaFinalCurso2;
                    }
                catch {}

                try
                {
                    DGV_consultaOrdenada.Rows[i].Cells[12].Value = InfoAdmin.Estudiantes[i].NotaTareaCurso3;
                    DGV_consultaOrdenada.Rows[i].Cells[13].Value = InfoAdmin.Estudiantes[i].NotaProyectoCurso3;
                    DGV_consultaOrdenada.Rows[i].Cells[14].Value = InfoAdmin.Estudiantes[i].NotaExamenCurso3;
                    DGV_consultaOrdenada.Rows[i].Cells[15].Value = InfoAdmin.Estudiantes[i].NotaFinalCurso3;
                    }
                catch {}

                try
                {
                    DGV_consultaOrdenada.Rows[i].Cells[16].Value = InfoAdmin.Estudiantes[i].NotaTareaCurso4;
                    DGV_consultaOrdenada.Rows[i].Cells[17].Value = InfoAdmin.Estudiantes[i].NotaProyectoCurso4;
                    DGV_consultaOrdenada.Rows[i].Cells[18].Value = InfoAdmin.Estudiantes[i].NotaExamenCurso4;
                    DGV_consultaOrdenada.Rows[i].Cells[19].Value = InfoAdmin.Estudiantes[i].NotaFinalCurso4;
                    }
                catch {}

                try
                {
                    DGV_consultaOrdenada.Rows[i].Cells[20].Value = InfoAdmin.Estudiantes[i].NotaTareaCurso5;
                    DGV_consultaOrdenada.Rows[i].Cells[21].Value = InfoAdmin.Estudiantes[i].NotaProyectoCurso5;
                    DGV_consultaOrdenada.Rows[i].Cells[22].Value = InfoAdmin.Estudiantes[i].NotaExamenCurso5;
                    DGV_consultaOrdenada.Rows[i].Cells[23].Value = InfoAdmin.Estudiantes[i].NotaFinalCurso5;
                    }
                catch {}

                    DGV_consultaOrdenada.Rows[i].Cells[24].Value = InfoAdmin.Estudiantes[i].PromedioGeneral;


                    /*DGV_consultaOrdenada.Rows[i].Cells[4].Value = InfoAdmin.Estudiantes[i].notasFinales[0];
                    DGV_consultaOrdenada.Rows[i].Cells[5].Value = InfoAdmin.Estudiantes[i].notasFinales[1];
                    DGV_consultaOrdenada.Rows[i].Cells[6].Value = InfoAdmin.Estudiantes[i].notasFinales[2];
                    DGV_consultaOrdenada.Rows[i].Cells[7].Value = InfoAdmin.Estudiantes[i].NotaFinal;
                    DGV_consultaOrdenada.Rows[i].Cells[8].Value = InfoAdmin.Estudiantes[i].PromedioGeneral;*/
                

                
            }

        }

        private void Consulta_Informacion_Load(object sender, EventArgs e)
        {

        }
    }
}
