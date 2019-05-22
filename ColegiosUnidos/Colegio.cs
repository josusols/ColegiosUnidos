using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ColegiosUnidos
{
    class Colegio
    { }

    class Obtener_datosCSV
    {
        public string NombreArchivo { get; set; }

        string linea = "";
        FileInfo informacionArchivo = null;
        StreamReader lectorArchivo = null;

        public Obtener_datosCSV(string nombreArchivo)
        {
            nombreArchivo = nombreArchivo.Trim();
            NombreArchivo = nombreArchivo;

            if (nombreArchivo.CompareTo("") == 0)
            {
                throw new Exception("Se debe ingresar un nombre de archivo.");
            }

            informacionArchivo = new FileInfo(nombreArchivo);
            if (!informacionArchivo.Exists)
            {
                throw new Exception("Debe ingresar un nombre de archivo existente.");
            }
        }
        int n = 3;
        public List<string[]> obtener_config()
        {
            lectorArchivo = new StreamReader(NombreArchivo, Encoding.Default);
            linea = lectorArchivo.ReadLine();

            List<string[]> listaconfig = new List<string[]>();

            for (int i = 0; i < n; i++)
            {
                {
                    listaconfig.Add(linea.Split(','));
                }
                if (i == 2)
                {
                    string[] h = linea.Split(',');
                    n = (n + Convert.ToInt32(h[1])) + 2;
                }
                linea = lectorArchivo.ReadLine();
            }
            lectorArchivo.Close();
            return listaconfig;
        }
        public List<string[]> obtener_estudiantes()
        {
            lectorArchivo = new StreamReader(NombreArchivo, Encoding.Default);
            linea = lectorArchivo.ReadLine();
            List<string[]> listaest = new List<string[]>();
            int q = n;
            for (int i = 0; i < n; i++)
            {
                if (i == (q - 1))
                {
                    string[] h = linea.Split(',');
                    n = (n + Convert.ToInt32(h[1]));
                }
                if (i > 7)
                {
                    {
                        listaest.Add(linea.Split(','));
                    }
                }
                linea = lectorArchivo.ReadLine();
            }
            lectorArchivo.Close();
            return listaest;
        }
        public string ObtenerNombreArchivoSalida(string leyenda)
        {
            // Variables locales
            FileInfo informacionArchivo = null;
            string nombreArchivoSalida = "";

            // Se carga la información del archivo
            informacionArchivo = new FileInfo(NombreArchivo);

            // Se genera el nuevo nombre
            nombreArchivoSalida = informacionArchivo.FullName.Replace(informacionArchivo.Extension, "_" + leyenda + informacionArchivo.Extension);

            // Se devuelve el nuevo nombre generado
            return nombreArchivoSalida;
        }
    }
}