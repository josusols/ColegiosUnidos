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
    public partial class Admin : Form
    {
        //Atributos de la clase.
        private int cantidadAlumnos;
        public int CantidadAlumnos
        {
            get
            {
                return cantidadAlumnos;
            }
            set
            {
                    if (value > 0 && value <= 1000)
                    {
                        cantidadAlumnos = value;
                    }
                    else
                    {
                        MessageBox.Show("La cantidad de estudiantes debe ser estar entre 1 y 300",".::INFO::.",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }
        }
        public int AlumnosIngresados = 0;

        private int cantidadCursos;
        public int CantidadCursos
        {
            get
            {
                return cantidadCursos;
            }
            set
            {
                if (value > 0 && value <= 5)
                {
                    cantidadCursos = value;
                }
                else
                {
                    MessageBox.Show("La cantidad de cursos debe ser estar entre 1 y 5", ".::INFO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public int CursosIngresados =0;
        
        public List<Curso> listaCursos = new List<Curso>();
        public List<Estudiante> Estudiantes = new List<Estudiante>(); //Siempre se usa.
        public List<Estudiante> EstudiantesOrdenados = new List<Estudiante>();

        //Constructor.
        public Login InfoLogin;
        public Admin(Login Login0)
        {
            InitializeComponent();
            InfoLogin = Login0;

            //Fondos.
            BTN_regresar.Image = InfoLogin.listaImg[2];
            this.BackgroundImage = InfoLogin.listaImg[3];
            PB_fondo.Image = InfoLogin.listaImg[4];
            BTN_confGeneral.Image = InfoLogin.listaImg[6];
            BTN_inModDatos.Image = InfoLogin.listaImg[7];
            BTN_consultaInfo.Image =  InfoLogin.listaImg[8];
            BTN_exImDatos.Image = InfoLogin.listaImg[9];
            this.Opacity = 0.95;
        }

        //Habilitacion de propiedades del administrador.
        private void Admin_VisibleChanged(object sender, EventArgs e)
        {
            if (listaCursos.Count() > 0)
            {
                BTN_inModDatos.Enabled = true;
            }

            if (Estudiantes.Count() > 0)
            {
                BTN_inModDatos.Enabled = true;
                BTN_consultaInfo.Enabled = true;
            }
        }

        //Boton regresar.
        private void BTN_regresar_Click(object sender, EventArgs e)
        {
            InfoLogin.Show();
            this.Hide();
        }
        
        //Boton configuracion general.
        private void BTN_confGeneral_Click(object sender, EventArgs e)
        {
            Configuracion config = new Configuracion(this);
            config.Show();
            this.Hide();
        }

        //Boton ingresar / modificar datos.
        private void BTN_inModDatos_Click(object sender, EventArgs e)
        {
            CMS_datos.Show(this, 439, 94);
        }

        //Ingresar datos.
        private void TSMI_ingreso_Click(object sender, EventArgs e)
        {
            IngresarDatos ingD = new IngresarDatos(this);
            ingD.Show();
            this.Hide();
        }

        //Modificar datos.
        private void TSMI_modificacion_Click(object sender, EventArgs e)
        {
            ModificarDatos modD = new ModificarDatos(this);
            modD.Show();
            this.Hide();
            
        }

        //Boton consultar informacion.
        private void BTN_consultaInfo_Click(object sender, EventArgs e)
        {
            Consulta_Informacion CI = new Consulta_Informacion(this);
            CI.Show();
            this.Hide();
        }

        //Boton exportar / importar datos.
        private void BTN_exImDatos_Click(object sender, EventArgs e)
        {
            Importar_datos imp = new Importar_datos(this);
            imp.Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
