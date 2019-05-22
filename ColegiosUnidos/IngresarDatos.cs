//Librerias.
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
    public partial class IngresarDatos : Form
    {
        //Constructor.
        public Admin InfoAdmin;
        public IngresarDatos(Admin Admin0)
        {
            InitializeComponent();
            InfoAdmin = Admin0;

            //Fondos.
            BTN_regresar.Image = InfoAdmin.InfoLogin.listaImg[2];
            this.BackgroundImage = InfoAdmin.InfoLogin.listaImg[3];
            this.Opacity = 0.95;

            //Llena el form y variables (si hay datos disponibles).
            for (int i = 0; i < InfoAdmin.Estudiantes.Count; i++)
            {
                CB_alumnos.Items.Add(InfoAdmin.Estudiantes[i].Nombres);
            }
        }

        //Boton regresar.
        private void BTN_regresar_Click(object sender, EventArgs e)
        {
            InfoAdmin.Show();
            this.Hide();
        }

        //Boton nuevo alumno.
        private void BTN_alumno_Click(object sender, EventArgs e)
        {
            try
            {
                //Control de estudiantes ingresados.
                if (InfoAdmin.AlumnosIngresados < InfoAdmin.CantidadAlumnos)
                {
                    //Agrega los datos del estudiante.
                    InfoAdmin.Estudiantes.Add(new Estudiante(
                Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del estudiante", ".::NOMBRE DEL ESTUDIANTE::.", ">> ¡Escribe aquí el nombre! <<", -1, -1),
                Microsoft.VisualBasic.Interaction.InputBox("Ingrese el apellido del estudiante", ".::APELLIDO DEL ESTUDIANTE::.", ">> ¡Escribe aquí el apellido! <<", -1, -1),
                Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el carnet del estudiante", ".::CARNET DEL ESTUDIANTE::.", ">> ¡Escribe aquí el carnet! <<", -1, -1)),
                Microsoft.VisualBasic.Interaction.InputBox("Ingrese el e-mail del estudiante", ".::E-MAIL DEL ESTUDIANTE::.", ">> ¡Escribe aquí el e-mail! <<", -1, -1)));

                    //Agrega los cursos al estudiante. *Importante*
                    InfoAdmin.Estudiantes[InfoAdmin.AlumnosIngresados].CursosPropios = new List<Curso>();
                    for (int i = 0; i < InfoAdmin.listaCursos.Count(); i++)
                    {
                        Curso tempC = new Curso(InfoAdmin.listaCursos[i].Nombre);
                        for (int j = 0; j < InfoAdmin.listaCursos[i].AC.Count(); j++) //j < 3.
                        {
                            tempC.AC[j].cantidad = InfoAdmin.listaCursos[i].AC[j].cantidad;
                            tempC.AC[j].porcentaje = InfoAdmin.listaCursos[i].AC[j].porcentaje;
                            tempC.AC[j].notas = new List<int>(InfoAdmin.listaCursos[i].AC[j].notas);
                        }
                        InfoAdmin.Estudiantes[InfoAdmin.AlumnosIngresados].CursosPropios.Add(tempC);
                        /*InfoAdmin.Estudiantes[InfoAdmin.AlumnosIngresados].CursosPropios = new List<Curso>(InfoAdmin.listaCursos);
                        No sirve porque hace referencias.*/
                    }

                    //Ingreso correcto.
                    MessageBox.Show("El alumno se ingreso correctamente", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CB_alumnos.Items.Add(InfoAdmin.Estudiantes[InfoAdmin.AlumnosIngresados].Nombres);
                    InfoAdmin.AlumnosIngresados++;
                }
                else
                {
                    MessageBox.Show("La lista de alumnos esta llena", ".::INFO::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ingrese datos validos", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Control del indice alumnos.
        int indiceEstudiante = 0;
        private void CB_alumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceEstudiante = CB_alumnos.SelectedIndex;
            ConfigurarNotas();

            //Reset a causa del movimiento de estudiantes.
            TB_e1.Text = "0";
            TB_e2.Text = "0";
            TB_e3.Text = "0";
            TB_e4.Text = "0";
            TB_e5.Text = "0";
            TB_p1.Text = "0";
            TB_p2.Text = "0";
            TB_p3.Text = "0";
            TB_t1.Text = "0";
            TB_t2.Text = "0";
            TB_t3.Text = "0";
            TB_t4.Text = "0";
            TB_t5.Text = "0";
        }

        //Metodo para configurar las notas.
        private void ConfigurarNotas()
        {
            //Tareas.
            P_tareas.Enabled = true;
            P_tareas.BackColor = Color.Black;
            CB_tareas.Items.Clear();
            for (int i = 0; i < InfoAdmin.CursosIngresados; i++)
            {
                CB_tareas.Items.Add(InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[i].Nombre);
            }

            //Proyectos.
            P_proyectos.Enabled = true;
            P_proyectos.BackColor = Color.Black;
            CB_proyectos.Items.Clear();
            for (int i = 0; i < InfoAdmin.CursosIngresados; i++)
            {
                CB_proyectos.Items.Add(InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[i].Nombre);
            }

            //Examenes.
            P_examenes.Enabled = true;
            P_examenes.BackColor = Color.Black;
            CB_examenes.Items.Clear();
            for (int i = 0; i < InfoAdmin.CursosIngresados; i++)
            {
                CB_examenes.Items.Add(InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[i].Nombre);
            }
        }

        int notasIngresadas = 0;
        //Boton agregar notas de tareas.
        private void BTN_notasTareas_Click(object sender, EventArgs e)
        {
            if (CB_tareas.Text != "")
            {
                notasIngresadas = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceTareas].AC[0].notasIngresadas;
                InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceTareas].AC[0].IngresarNotas();
                llenarTareas();
            }
            else
            {
                MessageBox.Show("Seleccione una opcion", ".::INFO::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton agregar notas de proyectos.
        private void BTN_notasProyectos_Click(object sender, EventArgs e)
        {
            if (CB_proyectos.Text != "")
            {
                notasIngresadas = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceProyectos].AC[1].notasIngresadas;
                InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceProyectos].AC[1].IngresarNotas();
                llenarProyectos();
            }
            else
            {
                MessageBox.Show("Seleccione una opcion", ".::INFO::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton agregar notas de examenes.
        private void BTN_notasExamenes_Click(object sender, EventArgs e)
        {
            if (CB_examenes.Text != "")
            {
                notasIngresadas = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceProyectos].AC[2].notasIngresadas;
                InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceExamenes].AC[2].IngresarNotas();
                llenarExamenes();
            }
            else
            {
                MessageBox.Show("Seleccione una opcion", ".::INFO::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Control del indice tareas.
        int indiceTareas = 0;
        private void CB_tareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceTareas = CB_tareas.SelectedIndex;
            llenarTareas();
        }

        //Control del indice proyectos.
        int indiceProyectos = 0;
        private void CB_proyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceProyectos = CB_proyectos.SelectedIndex;
            llenarProyectos();
        }

        //Control del indice examenes.
        int indiceExamenes = 0;
        private void CB_examenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceExamenes = CB_examenes.SelectedIndex;
            llenarExamenes();
        }

        //Llena los TextBox de las tareas.
        public void llenarTareas()
        {
            try
            {
                TB_t1.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceTareas].AC[0].notas[0].ToString();
            }
            catch
            {
                TB_t1.Text = "0";
            }

            try
            {
                TB_t2.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceTareas].AC[0].notas[1].ToString();
            }
            catch
            {
                TB_t2.Text = "0";
            }

            try
            {
                TB_t3.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceTareas].AC[0].notas[2].ToString();
            }
            catch
            {
                TB_t3.Text = "0";
            }

            try
            {
                TB_t4.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceTareas].AC[0].notas[3].ToString();
            }
            catch
            {
                TB_t4.Text = "0";
            }

            try
            {
                TB_t5.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceTareas].AC[0].notas[4].ToString();
            }
            catch
            {
                TB_t5.Text = "0";
            }
        }

        //Llena los TextBox de los proyectos.
        public void llenarProyectos()
        {
            try
            {
                TB_p1.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceProyectos].AC[1].notas[0].ToString();
            }
            catch
            {
                TB_p1.Text = "0";
            }

            try
            {
                TB_p2.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceProyectos].AC[1].notas[1].ToString();
            }
            catch
            {
                TB_p2.Text = "0";
            }

            try
            {
                TB_p3.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceProyectos].AC[1].notas[2].ToString();
            }
            catch
            {
                TB_p3.Text = "0";
            }
        }

        //Llena los TextBox de los examenes.
        public void llenarExamenes()
        {
            try
            {
                TB_e1.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceExamenes].AC[2].notas[0].ToString();
            }
            catch
            {
                TB_e1.Text = "0";
            }

            try
            {
                TB_e2.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceExamenes].AC[2].notas[1].ToString();
            }
            catch
            {
                TB_e2.Text = "0";
            }

            try
            {
                TB_e3.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceExamenes].AC[2].notas[2].ToString();
            }
            catch
            {
                TB_e3.Text = "0";
            }

            try
            {
                TB_e4.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceExamenes].AC[2].notas[3].ToString();
            }
            catch
            {
                TB_e4.Text = "0";
            }

            try
            {
                TB_e5.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceExamenes].AC[2].notas[4].ToString();
            }
            catch
            {
                TB_e5.Text = "0";
            }
        }
    }
}

