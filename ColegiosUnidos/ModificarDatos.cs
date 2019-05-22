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
    public partial class ModificarDatos : Form
    {
        //Constructor.
        public Admin InfoAdmin;
        public ModificarDatos(Admin Admin0)
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

        //Control del indice alumnos.
        int indiceEstudiante = 0;
        private void CB_alumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceEstudiante = CB_alumnos.SelectedIndex;

            TB_apellidos.Text = InfoAdmin.Estudiantes[indiceEstudiante].Apellidos;
            TB_carnet.Text = InfoAdmin.Estudiantes[indiceEstudiante].Carnet.ToString();
            TB_email.Text = InfoAdmin.Estudiantes[indiceEstudiante].Email;
            
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

            TB_e1.Enabled = false;
            TB_e2.Enabled = false;
            TB_e3.Enabled = false;
            TB_e4.Enabled = false;
            TB_e5.Enabled = false;
            TB_p1.Enabled = false;
            TB_p2.Enabled = false;
            TB_p3.Enabled = false;
            TB_t1.Enabled = false;
            TB_t2.Enabled = false;
            TB_t3.Enabled = false;
            TB_t4.Enabled = false;
            TB_t5.Enabled = false;
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
                TB_t1.Enabled = true;
            }
            catch
            {
                TB_t1.Text = "0";
                TB_t1.Enabled = false;
            }

            try
            {
                TB_t2.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceTareas].AC[0].notas[1].ToString();
                TB_t2.Enabled = true;
            }
            catch
            {
                TB_t2.Text = "0";
                TB_t2.Enabled = false;
            }

            try
            {
                TB_t3.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceTareas].AC[0].notas[2].ToString();
                TB_t3.Enabled = true;
            }
            catch
            {
                TB_t3.Text = "0";
                TB_t3.Enabled = false;
            }

            try
            {
                TB_t4.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceTareas].AC[0].notas[3].ToString();
                TB_t4.Enabled = true;
            }
            catch
            {
                TB_t4.Text = "0";
                TB_t4.Enabled = false;
            }

            try
            {
                TB_t5.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceTareas].AC[0].notas[4].ToString();
                TB_t5.Enabled = true;
            }
            catch
            {
                TB_t5.Text = "0";
                TB_t5.Enabled = false;
            }
        }

        //Llena los TextBox de los proyectos.
        public void llenarProyectos()
        {
            try
            {
                TB_p1.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceProyectos].AC[1].notas[0].ToString();
                TB_p1.Enabled = true;
            }
            catch
            {
                TB_p1.Text = "0";
                TB_p1.Enabled = false;
            }

            try
            {
                TB_p2.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceProyectos].AC[1].notas[1].ToString();
                TB_p2.Enabled = true;
            }
            catch
            {
                TB_p2.Text = "0";
                TB_p2.Enabled = false;
            }

            try
            {
                TB_p3.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceProyectos].AC[1].notas[2].ToString();
                TB_p3.Enabled = true;
            }
            catch
            {
                TB_p3.Text = "0";
                TB_p3.Enabled = false;
            }
        }

        //Llena los TextBox de los examenes.
        public void llenarExamenes()
        {
            try
            {
                TB_e1.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceExamenes].AC[2].notas[0].ToString();
                TB_e1.Enabled = true;
            }
            catch
            {
                TB_e1.Text = "0";
                TB_e1.Enabled = false;
            }

            try
            {
                TB_e2.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceExamenes].AC[2].notas[1].ToString();
                TB_e2.Enabled = true;
            }
            catch
            {
                TB_e2.Text = "0";
                TB_e2.Enabled = false;
            }

            try
            {
                TB_e3.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceExamenes].AC[2].notas[2].ToString();
                TB_e3.Enabled = true;
            }
            catch
            {
                TB_e3.Text = "0";
                TB_e3.Enabled = false;
            }

            try
            {
                TB_e4.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceExamenes].AC[2].notas[3].ToString();
                TB_e4.Enabled = true;
            }
            catch
            {
                TB_e4.Text = "0";
                TB_e4.Enabled = false;
            }

            try
            {
                TB_e5.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceExamenes].AC[2].notas[4].ToString();
                TB_e5.Enabled = true;
            }
            catch
            {
                TB_e5.Text = "0";
                TB_e5.Enabled = false;
            }
        }

        //Modificar nombres.
        private void CB_alumnos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (CB_alumnos.Text == "")
                {
                    MessageBox.Show("El campo no puede estar vacio", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string nuevoValor = CB_alumnos.Text;
                    InfoAdmin.Estudiantes[indiceEstudiante].Nombres = nuevoValor;
                    CB_alumnos.Items[indiceEstudiante] = InfoAdmin.Estudiantes[indiceEstudiante].Nombres;
                    MessageBox.Show("El campo se actualizo correctamente", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Modificar apellidos.
        private void TB_apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TB_apellidos.Text == "")
                {
                    MessageBox.Show("El campo no puede estar vacio", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string nuevoValor = TB_apellidos.Text;
                    InfoAdmin.Estudiantes[indiceEstudiante].Apellidos = nuevoValor;
                    TB_apellidos.Text = InfoAdmin.Estudiantes[indiceEstudiante].Apellidos;
                    MessageBox.Show("El campo se actualizo correctamente", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Modificar carnet.
        private void TB_carnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TB_carnet.Text == "")
                {
                    MessageBox.Show("El campo no puede estar vacio", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string nuevoValor = TB_carnet.Text;
                    InfoAdmin.Estudiantes[indiceEstudiante].Carnet = Convert.ToInt32(nuevoValor);
                    TB_carnet.Text = InfoAdmin.Estudiantes[indiceEstudiante].Carnet.ToString();
                    MessageBox.Show("El campo se actualizo correctamente", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Modificar email.
        private void TB_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TB_email.Text == "")
                {
                    MessageBox.Show("El campo no puede estar vacio", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string nuevoValor = TB_email.Text;
                    InfoAdmin.Estudiantes[indiceEstudiante].Email = nuevoValor;
                    TB_email.Text = InfoAdmin.Estudiantes[indiceEstudiante].Email;
                    MessageBox.Show("El campo se actualizo correctamente", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Modificar nota tarea 1.
        private void TB_t1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TB_t1.Text == "")
                {
                    MessageBox.Show("El campo no puede estar vacio", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int nuevoValor = Convert.ToInt32(TB_t1.Text);
                    InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceTareas].AC[0].notas[0] = nuevoValor;
                    TB_t1.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceTareas].AC[0].notas[0].ToString();
                    MessageBox.Show("El campo se actualizo correctamente", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Modificar nota tarea 2.
        private void TB_t2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TB_t2.Text == "")
                {
                    MessageBox.Show("El campo no puede estar vacio", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int nuevoValor = Convert.ToInt32(TB_t2.Text);
                    InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceTareas].AC[0].notas[1] = nuevoValor;
                    TB_t2.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceTareas].AC[0].notas[1].ToString();
                    MessageBox.Show("El campo se actualizo correctamente", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Modificar nota tarea 3.
        private void TB_t3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TB_t3.Text == "")
                {
                    MessageBox.Show("El campo no puede estar vacio", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int nuevoValor = Convert.ToInt32(TB_t3.Text);
                    InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceTareas].AC[0].notas[2] = nuevoValor;
                    TB_t3.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceTareas].AC[0].notas[2].ToString();
                    MessageBox.Show("El campo se actualizo correctamente", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Modificar nota tarea 4.
        private void TB_t4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TB_t4.Text == "")
                {
                    MessageBox.Show("El campo no puede estar vacio", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int nuevoValor = Convert.ToInt32(TB_t4.Text);
                    InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceTareas].AC[0].notas[3] = nuevoValor;
                    TB_t4.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceTareas].AC[0].notas[3].ToString();
                    MessageBox.Show("El campo se actualizo correctamente", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Modificar nota tarea 5.
        private void TB_t5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TB_t5.Text == "")
                {
                    MessageBox.Show("El campo no puede estar vacio", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int nuevoValor = Convert.ToInt32(TB_t5.Text);
                    InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceTareas].AC[0].notas[4] = nuevoValor;
                    TB_t5.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceTareas].AC[0].notas[4].ToString();
                    MessageBox.Show("El campo se actualizo correctamente", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Modificar nota proyecto 1.
        private void TB_p1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TB_p1.Text == "")
                {
                    MessageBox.Show("El campo no puede estar vacio", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int nuevoValor = Convert.ToInt32(TB_p1.Text);
                    InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceProyectos].AC[1].notas[0] = nuevoValor;
                    TB_p1.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceProyectos].AC[1].notas[0].ToString();
                    MessageBox.Show("El campo se actualizo correctamente", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Modificar nota proyecto 2.
        private void TB_p2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TB_p2.Text == "")
                {
                    MessageBox.Show("El campo no puede estar vacio", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int nuevoValor = Convert.ToInt32(TB_p2.Text);
                    InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceProyectos].AC[1].notas[1] = nuevoValor;
                    TB_p2.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceProyectos].AC[1].notas[1].ToString();
                    MessageBox.Show("El campo se actualizo correctamente", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Modificar nota proyecto 3.
        private void TB_p3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TB_p3.Text == "")
                {
                    MessageBox.Show("El campo no puede estar vacio", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int nuevoValor = Convert.ToInt32(TB_p3.Text);
                    InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceProyectos].AC[1].notas[2] = nuevoValor;
                    TB_p3.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceProyectos].AC[1].notas[2].ToString();
                    MessageBox.Show("El campo se actualizo correctamente", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Modificar nota examen 1.
        private void TB_e1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TB_e1.Text == "")
                {
                    MessageBox.Show("El campo no puede estar vacio", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int nuevoValor = Convert.ToInt32(TB_e1.Text);
                    InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceExamenes].AC[2].notas[0] = nuevoValor;
                    TB_e1.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceExamenes].AC[2].notas[0].ToString();
                    MessageBox.Show("El campo se actualizo correctamente", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Modificar nota examen 2.
        private void TB_e2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TB_e2.Text == "")
                {
                    MessageBox.Show("El campo no puede estar vacio", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int nuevoValor = Convert.ToInt32(TB_e2.Text);
                    InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceExamenes].AC[2].notas[1] = nuevoValor;
                    TB_e2.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceExamenes].AC[2].notas[1].ToString();
                    MessageBox.Show("El campo se actualizo correctamente", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Modificar nota examen 3.
        private void TB_e3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TB_e3.Text == "")
                {
                    MessageBox.Show("El campo no puede estar vacio", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int nuevoValor = Convert.ToInt32(TB_e3.Text);
                    InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceExamenes].AC[2].notas[2] = nuevoValor;
                    TB_e3.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceExamenes].AC[2].notas[2].ToString();
                    MessageBox.Show("El campo se actualizo correctamente", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        
        //Modificar nota examen 4.
        private void TB_e4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TB_e4.Text == "")
                {
                    MessageBox.Show("El campo no puede estar vacio", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int nuevoValor = Convert.ToInt32(TB_e4.Text);
                    InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceExamenes].AC[2].notas[3] = nuevoValor;
                    TB_e4.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceExamenes].AC[2].notas[3].ToString();
                    MessageBox.Show("El campo se actualizo correctamente", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Modificar nota examen 5.
        private void TB_e5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TB_e5.Text == "")
                {
                    MessageBox.Show("El campo no puede estar vacio", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int nuevoValor = Convert.ToInt32(TB_e5.Text);
                    InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceExamenes].AC[2].notas[4] = nuevoValor;
                    TB_e5.Text = InfoAdmin.Estudiantes[indiceEstudiante].CursosPropios[indiceExamenes].AC[2].notas[4].ToString();
                    MessageBox.Show("El campo se actualizo correctamente", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
