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
    public partial class Configuracion : Form
    {
        //Constructor.
        Admin InfoAdmin;
        public Configuracion(Admin Admin0)
        {
            InitializeComponent();
            InfoAdmin = Admin0;

            //Fondos.
            BTN_regresar.Image = InfoAdmin.InfoLogin.listaImg[2];
            this.BackgroundImage = InfoAdmin.InfoLogin.listaImg[3];
            this.Opacity = 0.95;

            //Llena el form y variables (si hay datos disponibles).
            TB_noAlumnos.Text = InfoAdmin.CantidadAlumnos.ToString();
            TB_noCursos.Text = InfoAdmin.CantidadCursos.ToString();
            for (int i = 0; i < InfoAdmin.listaCursos.Count; i++)
            {
                CB_cursos.Items.Add(InfoAdmin.listaCursos[i].Nombre);
            }

            if (InfoAdmin.CantidadCursos != 0)
            {
                P_curso.Enabled = true;
                P_curso.BackColor = Color.Black;
            }
            else
            {
                P_curso.Enabled = false;
                P_curso.BackColor = Color.DimGray;
            }

            cursosIngresados = InfoAdmin.CursosIngresados;
        }

        //Boton regresar.
        private void BTN_regresar_Click(object sender, EventArgs e)
        {
            InfoAdmin.CursosIngresados = cursosIngresados;
            InfoAdmin.Show();
            this.Hide();
        }

        //Boton cantidad estudiantes.
        private void BTN_cantidadEst_Click(object sender, EventArgs e)
        {
            try
            {
                InfoAdmin.CantidadAlumnos = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad de estudiantes", ".::CANTIDAD DE ESTUDIANTES::.", ">> ¡Escribe aquí la cantidad! <<", -1, -1));
                TB_noAlumnos.Text = InfoAdmin.CantidadAlumnos.ToString();
            }
            catch
            {
                MessageBox.Show("Ingrese una cantidad valida", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton cantidad cursos.
        private void BTN_cantidadCur_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad de cursos", ".::CANTIDAD DE CURSOS::.", ">> ¡Escribe aquí la cantidad! <<", -1, -1));
                if (cantidad >= InfoAdmin.CantidadCursos)
                {
                    InfoAdmin.CantidadCursos = cantidad;
                    TB_noCursos.Text = InfoAdmin.CantidadCursos.ToString();
                    if (Convert.ToInt32(TB_noCursos.Text) != 0)
                    {
                        //La creacion de cursos se activa.
                        P_curso.Enabled = true;
                        P_curso.BackColor = Color.Black;
                        //Especificamente.
                        BTN_curso.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("La nueva cantidad no puede ser menor a la ya ingresada", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ingrese una cantidad valida", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (InfoAdmin.CantidadCursos == 0)
                {
                    //La creacion de cursos se desactiva.
                    P_curso.Enabled = false;
                    P_curso.BackColor = Color.DimGray;
                }
            }
        }
        
        //Control de cursos ingresados.
        private int cursosIngresados = 0;

        //Boton nuevo curso (procesos a un nivel mas bajo).
        private void BTN_curso_Click(object sender, EventArgs e)
        {
            if (cursosIngresados < InfoAdmin.CantidadCursos)
            {
                string nombreCurso = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del curso", ".::NOMBRE DEL CURSO::.", ">> ¡Escribe aquí el nombre! <<", -1, -1);
                if (nombreCurso == ">> ¡Escribe aquí el nombre! <<" || nombreCurso == "")
                {
                    MessageBox.Show("Ingrese un nombre valido", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cursosIngresados--;
                }
                else
                {
                    InfoAdmin.listaCursos.Add(new Curso(nombreCurso));
                    CB_cursos.Items.Add(InfoAdmin.listaCursos[cursosIngresados].Nombre);

                    for (int i = 0; i < InfoAdmin.AlumnosIngresados; i++)
                    {
                        InfoAdmin.Estudiantes[i].CursosPropios.Add(new Curso(nombreCurso));
                    }
                }
            }
            else
            {
                MessageBox.Show("La lista de cursos esta llena", ".::INFO::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BTN_curso.Enabled = false;
                cursosIngresados--;
            }
            cursosIngresados++;
        }

        //Control del indice.
        private int indice;
        private void CB_cursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = CB_cursos.SelectedIndex;
            ConfigurarCurso();
        }

        //Modificacion del nombre de los cursos.
        private void CB_cursos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (CB_cursos.Text == "")
                {
                    MessageBox.Show("El campo no puede estar vacio", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string nuevoValor = CB_cursos.Text;
                    InfoAdmin.listaCursos[indice].Nombre = CB_cursos.Text;
                    CB_cursos.Items[indice] = InfoAdmin.listaCursos[indice].Nombre;
                    MessageBox.Show("El campo se actualizo correctamente", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Metodo para configurar los cursos.
        private void ConfigurarCurso()
        {
            //Tareas.
            P_tareas.Enabled = true;
            P_tareas.BackColor = Color.Black;
            TB_cantidadTareas.Text = InfoAdmin.listaCursos[indice].AC[0].cantidad.ToString();
            TB_porcentajeTareas.Text = InfoAdmin.listaCursos[indice].AC[0].porcentaje.ToString();

            //Proyectos.
            P_proyectos.Enabled = true;
            P_proyectos.BackColor = Color.Black;
            TB_cantidadProyectos.Text = InfoAdmin.listaCursos[indice].AC[1].cantidad.ToString();
            TB_porcentajeProyectos.Text = InfoAdmin.listaCursos[indice].AC[1].porcentaje.ToString();
            
            //Examenes.
            P_examenes.Enabled = true;
            P_examenes.BackColor = Color.Black;
            TB_cantidadExamenes.Text = InfoAdmin.listaCursos[indice].AC[2].cantidad.ToString();
            TB_porcentajeExamenes.Text = InfoAdmin.listaCursos[indice].AC[2].porcentaje.ToString();
        }

        /*<Procesos a un nivel mas bajo>*/
        //Boton cantidad tareas.
        private void BTN_cantidadTareas_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad de tareas", ".::CANTIDAD DE TAREAS::.", ">> ¡Escribe aquí la cantidad! <<", -1, -1));
                InfoAdmin.listaCursos[indice].AC[0].IngresarCantidad("tareas", cantidad,true);
                for (int i = 0; i < InfoAdmin.AlumnosIngresados; i++)
                {
                    InfoAdmin.Estudiantes[i].CursosPropios[indice].AC[0].IngresarCantidad("tareas", cantidad,false);
                }
            TB_cantidadTareas.Text = InfoAdmin.listaCursos[indice].AC[0].cantidad.ToString();
            }
            catch
            {
                MessageBox.Show("Ingrese una cantidad valida", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton porcentaje tareas.
        private void BTN_porcentajeTareas_Click(object sender, EventArgs e)
        {
            try
            {
                InfoAdmin.listaCursos[indice].AC[0].IngresarPorcentaje(InfoAdmin.listaCursos[indice].AC[1].porcentaje, InfoAdmin.listaCursos[indice].AC[2].porcentaje);
                for (int i = 0; i < InfoAdmin.AlumnosIngresados; i++)
                {
                    InfoAdmin.Estudiantes[i].CursosPropios[indice].AC[0].IngresarPorcentaje(InfoAdmin.listaCursos[indice].AC[1].porcentaje, InfoAdmin.listaCursos[indice].AC[2].porcentaje);
                }
                TB_porcentajeTareas.Text = InfoAdmin.listaCursos[indice].AC[0].porcentaje.ToString();
            }
            catch
            {
                MessageBox.Show("Ingrese una cantidad valida", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton cantidad proyectos.
        private void BTN_cantidadProyectos_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad de proyectos", ".::CANTIDAD DE PROYECTOS::.", ">> ¡Escribe aquí la cantidad! <<", -1, -1));
                InfoAdmin.listaCursos[indice].AC[1].IngresarCantidad("proyectos", cantidad,true);
                for (int i = 0; i < InfoAdmin.AlumnosIngresados; i++)
                {
                    InfoAdmin.Estudiantes[i].CursosPropios[indice].AC[1].IngresarCantidad("proyectos", cantidad,false);
                }
                TB_cantidadProyectos.Text = InfoAdmin.listaCursos[indice].AC[1].cantidad.ToString();
            }
            catch
            {
                MessageBox.Show("Ingrese una cantidad valida", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton porcentaje proyectos.
        private void BTN_porcentajeProyectos_Click(object sender, EventArgs e)
        {
            try
            {
                InfoAdmin.listaCursos[indice].AC[1].IngresarPorcentaje(InfoAdmin.listaCursos[indice].AC[0].porcentaje, InfoAdmin.listaCursos[indice].AC[2].porcentaje);
                for (int i = 0; i < InfoAdmin.AlumnosIngresados; i++)
                {
                    InfoAdmin.Estudiantes[i].CursosPropios[indice].AC[1].IngresarPorcentaje(InfoAdmin.listaCursos[indice].AC[0].porcentaje, InfoAdmin.listaCursos[indice].AC[2].porcentaje);
                }
                TB_porcentajeProyectos.Text = InfoAdmin.listaCursos[indice].AC[1].porcentaje.ToString();
            }
            catch
            {
                MessageBox.Show("Ingrese una cantidad valida", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton cantidad examenes.
        private void BTN_cantidadExamenes_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad de examenes", ".::CANTIDAD DE EXAMENES::.", ">> ¡Escribe aquí la cantidad! <<", -1, -1));
            InfoAdmin.listaCursos[indice].AC[2].IngresarCantidad("examenes", cantidad,true);
                for (int i = 0; i < InfoAdmin.AlumnosIngresados; i++)
                {
                    InfoAdmin.Estudiantes[i].CursosPropios[indice].AC[2].IngresarCantidad("examenes", cantidad,false);
                }
                TB_cantidadExamenes.Text = InfoAdmin.listaCursos[indice].AC[2].cantidad.ToString();
            }
            catch
            {
                MessageBox.Show("Ingrese una cantidad valida", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton porcentaje examenes.
        private void BTN_porcentajeExamenes_Click(object sender, EventArgs e)
        {
            try
            {
                InfoAdmin.listaCursos[indice].AC[2].IngresarPorcentaje(InfoAdmin.listaCursos[indice].AC[1].porcentaje, InfoAdmin.listaCursos[indice].AC[0].porcentaje);
                for (int i = 0; i < InfoAdmin.AlumnosIngresados; i++)
                {
                    InfoAdmin.Estudiantes[i].CursosPropios[indice].AC[2].IngresarPorcentaje(InfoAdmin.listaCursos[indice].AC[1].porcentaje, InfoAdmin.listaCursos[indice].AC[0].porcentaje);
                }
                TB_porcentajeExamenes.Text = InfoAdmin.listaCursos[indice].AC[2].porcentaje.ToString();
            }
            catch
            {
                MessageBox.Show("Ingrese una cantidad valida", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
