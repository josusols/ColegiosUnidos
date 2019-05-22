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
    public partial class Login : Form
    {
        //Constructor.
        public Login()
        {
            InitializeComponent();

            //Agregar elementos a la lista de imagenes.
            listaImg.Add(new Bitmap("../../Resources/fondo.gif"));
            listaImg.Add(new Bitmap("../../Resources/logo.png"));
            listaImg.Add(new Bitmap("../../Resources/atras.png"));
            listaImg.Add(new Bitmap("../../Resources/mac.png"));
            listaImg.Add(new Bitmap("../../Resources/fondo2.gif"));
            listaImg.Add(new Bitmap("../../Resources/fondo3.gif"));
            listaImg.Add(new Bitmap("../../Resources/configuracion.png"));
            listaImg.Add(new Bitmap("../../Resources/ingreso.png"));
            listaImg.Add(new Bitmap("../../Resources/consulta.png"));
            listaImg.Add(new Bitmap("../../Resources/importar.png"));


            //Transparencia.
            L_usuario.Parent = PB_fondo;
            L_contraseña.Parent = PB_fondo;
            PB_logo.Parent = PB_fondo;
            this.Opacity = 0.9;

            //Fondos.
            PB_fondo.Image = listaImg[0];
            PB_logo.Image = listaImg[1];
            Pulsaciones.Start();
        }

        //Lista de imagenes.
        public List<Bitmap> listaImg = new List<Bitmap>();
        
        //Metodo analisis de teclas.
        private void Teclas(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Entrar();
            }
        }

        //Limpiar datos.
        private void LimpiarDatos()
        {
            TB_usuario.Clear();
            TB_contraseña.Clear();
        }

        //Metodo para ingresar al sistema.
        private void Entrar()
        {
            if (TB_usuario.Text == "admin" && TB_contraseña.Text == "admin") //Login con admin.
            {
                LimpiarDatos();
                Admin admin = new Admin(this);
                admin.Show();
                this.Hide();
            }
            else if (TB_usuario.Text == "usuario" && TB_contraseña.Text == "usuario2015") //Login con usuario.
            {
                LimpiarDatos();
                Usuario usuario = new Usuario(this);
                usuario.Show();
                this.Hide();
            }
            else //Si no es admin ni usuario.
            {
                MessageBox.Show("¡Debe ingresar con una cuenta valida!\n[admin o usuario]", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarDatos();
            }
        }

        //Parpadeo de los TextBox.
        int pulsacion = 0;
        private void Pulsaciones_Tick(object sender, EventArgs e)
        {
            pulsacion++;
            if (pulsacion % 2 == 0)
            {
                TB_usuario.BackColor = Color.DimGray;
                TB_contraseña.BackColor = Color.Black;
            }
            else
            {
                TB_usuario.BackColor = Color.Black;
                TB_contraseña.BackColor = Color.DimGray;
            }
        }

        private void PB_fondo_Click(object sender, EventArgs e)
        {

        }
    }
}
