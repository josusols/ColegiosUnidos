using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ColegiosUnidos
{
    public partial class Importar_datos : Form
    {
        Admin InfoAdmin;
        public Importar_datos(Admin Admin0)
        {
            InfoAdmin = Admin0;
            InitializeComponent();
            BTN_regresar1.Image = InfoAdmin.InfoLogin.listaImg[2];
            BTN_regresar2.Image = InfoAdmin.InfoLogin.listaImg[2];


            openFileDialog.Title = "Elija el archivo con la configuracion y datos:";
            openFileDialog.Filter = "Archivos separados por comas|*.csv";
        }
        List<string[]> list1 = new List<string[]>();
        List<string[]> list2 = new List<string[]>();
        Obtener_datosCSV ob;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Hay un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Obtener_datosCSV obt = new Obtener_datosCSV(openFileDialog.FileName);

            list1 = obt.obtener_config();
            list2 = obt.obtener_estudiantes();

            DataTable dt = new DataTable();
            int cols = list1[0].Count();
            for (int i = 0; i < cols; i++)
            {
                dt.Columns.Add(list1[0][i].ToUpper(), typeof(string));
            }
            DataRow row;
            for (int j = 1; j < list1.Count(); j++)
            {
                row = dt.NewRow();
                for (int f = 0; f < cols; f++)
                {
                    if (j < list1.Count())
                    {

                        row[f] = list1[j][f];
                    }
                }
                dt.Rows.Add(row);
            }
            int cont = 0;
            for (int j = list1.Count(); j < (list1.Count() + list2.Count()); j++)
            {

                row = dt.NewRow();
                for (int f = 0; f < cols; f++)
                {
                    if (j < (list1.Count() + list2.Count()))
                    {
                        row[f] = list2[cont][f];
                    }

                }
                cont = cont + 1;
                dt.Rows.Add(row);
            }
            OFD_TablaDatos.DataSource = dt;
            ob = obt;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Cantidad de estudiantes.
            InfoAdmin.AlumnosIngresados = 1000;
            for (int i = 0; i < list2.Count()-1; i++)
            {
                int z = i + 1;
                InfoAdmin.Estudiantes.Add(new Estudiante(list2[z][1], list2[z][2], Convert.ToInt32(list2[z][3]), list2[z][4]));
                InfoAdmin.CursosIngresados = Convert.ToInt32(list1[2][1]);
                //Cantidad de cursos.
                
                for (int g = 0; g < InfoAdmin.CursosIngresados; g++)
                {
                    InfoAdmin.Estudiantes[i].CursosPropios.Add(new Curso(list1[3 + g][1]));
                }
                //Configuracion de cursos.
                for (int g = 0; g < InfoAdmin.CursosIngresados; g++)
                {
                    InfoAdmin.Estudiantes[i].CursosPropios[g].AC[0].cantidad = Convert.ToInt32(list1[3 + g][3]);

                    for (int j = 0; j < InfoAdmin.Estudiantes[i].CursosPropios[g].AC[0].cantidad; j++)
                    {
                        InfoAdmin.Estudiantes[i].CursosPropios[g].AC[0].porcentajes.Add(Convert.ToDouble(list1[3 + g][4 + j]));
                        if (g == 0)
                        {
                            InfoAdmin.Estudiantes[i].CursosPropios[g].AC[0].notas.Add(Convert.ToInt32(list2[z][7 + j]));
                        }
                        else
                        {
                            InfoAdmin.Estudiantes[i].CursosPropios[g].AC[0].notas.Add(Convert.ToInt32(list2[z][22 + (15 * (g - 1)) + j]));
                        }
                    }
                    InfoAdmin.Estudiantes[i].CursosPropios[g].AC[1].cantidad = Convert.ToInt32(list1[3 + g][10]);
                    for (int j = 0; j < InfoAdmin.Estudiantes[i].CursosPropios[g].AC[1].cantidad; j++)
                    {
                        InfoAdmin.Estudiantes[i].CursosPropios[g].AC[1].porcentajes.Add(Convert.ToDouble(list1[3 + g][11 + j]));
                        if (g == 0)
                        {
                            InfoAdmin.Estudiantes[i].CursosPropios[g].AC[1].notas.Add(Convert.ToInt32(list2[z][13 + j]));
                        }
                        else
                        {
                            InfoAdmin.Estudiantes[i].CursosPropios[g].AC[1].notas.Add(Convert.ToInt32(list2[z][28 + (15 * (g - 1)) + j]));
                        }

                    }
                    InfoAdmin.Estudiantes[i].CursosPropios[g].AC[2].cantidad = Convert.ToInt32(list1[3 + g][15]);

                    for (int j = 0; j < InfoAdmin.Estudiantes[i].CursosPropios[g].AC[2].cantidad; j++)
                    {
                        InfoAdmin.Estudiantes[i].CursosPropios[g].AC[2].porcentajes.Add(Convert.ToDouble(list1[3 + g][16 + j]));
                        if (g == 0)
                        {
                            InfoAdmin.Estudiantes[i].CursosPropios[g].AC[2].notas.Add(Convert.ToInt32(list2[z][17 + j]));
                        }
                        else
                        {
                            InfoAdmin.Estudiantes[i].CursosPropios[g].AC[2].notas.Add(Convert.ToInt32(list2[z][32 + (15 * (g - 1)) + j]));
                        }

                    }
                }
               

            }
            
            MessageBox.Show("sus datos han sido cargados exitosamente");


        }

        private void BTN_regresar_Click(object sender, EventArgs e)
        {
            InfoAdmin.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InfoAdmin.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            

           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            StreamWriter escritorArchivo = null;
            string leyenda = "Archivo_Salida";

            // Se abre el archivo
            escritorArchivo = new StreamWriter("archivo_salida", false);

            
            int cont = InfoAdmin.AlumnosIngresados;
            for (int i = 0; i < cont; i++)
            {
               
                escritorArchivo.WriteLine(InfoAdmin.Estudiantes[i].Nombres + "," + InfoAdmin.Estudiantes[i].Apellidos + "," + InfoAdmin.Estudiantes[i].Email + ","+
                  InfoAdmin.Estudiantes[i].Carnet.ToString() + ","  ) ;
               
            }
            MessageBox.Show("Su archivo se ha escrito correctamente.");
            // Se cierra el archivo
            escritorArchivo.Close();
        }

        private void Importar_datos_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void OFD_TablaDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


