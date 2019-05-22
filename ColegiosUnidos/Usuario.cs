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
    public partial class Usuario : Form
    {
        
        //Constructor.
        Login InfoLogin;
        public Usuario(Login Login0)
        {
            InitializeComponent();
            InfoLogin = Login0;

            
            //Fondo.
            BTN_regresar.Image = InfoLogin.listaImg[2];
            this.BackgroundImage = InfoLogin.listaImg[3];
            PB_fondo.Image = InfoLogin.listaImg[5];
            this.Opacity = 0.95;
        }
        

        //Boton regresar.
        private void BTN_regresar_Click(object sender, EventArgs e)
        {
            InfoLogin.Show();
            this.Hide();
        }

        private void BTN_exImDatos_Click(object sender, EventArgs e)
        {
            Admin InfoAdmin = new Admin(InfoLogin);
            Importar_datos imp = new Importar_datos(InfoAdmin);
            imp.Show();
            this.Hide();
        }

        private void PB_fondo_Click(object sender, EventArgs e)
        {

        }

        private void BTN_consultaInfo_Click(object sender, EventArgs e)
        {
            Admin InfoAdmin = new Admin(InfoLogin);
            Consulta_Informacion CI = new Consulta_Informacion(InfoAdmin);
            CI.Show();
            this.Hide();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
