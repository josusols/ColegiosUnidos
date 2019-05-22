//Librerias.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColegiosUnidos
{
    public class Curso
    {
        public string Nombre;
        public List<Actividad> AC = new List<Actividad>();
        public double notaFinal;

        //Contructor.
        public Curso(string nombre)
        {
            Nombre = nombre;
            AC.Add(new Actividad("Tareas"));
            AC.Add(new Actividad("Proyectos"));
            AC.Add(new Actividad("Examenes"));
        }
    }

    public class Actividad
    {
        public string Nombre;
        public Actividad(string nombre)
        {
            Nombre = nombre;
        }

        public int cantidad { get; set; }
        public void IngresarCantidad(string opcion, int canti, bool EsAdmin)
        {

            switch (opcion)
            {
                case "tareas":
                    if (canti > 0 && canti <= 5)
                    {
                        cantidad = canti;
                        if (EsAdmin)
                        {
                            MessageBox.Show("La cantidad de " + opcion + " fue aceptada", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (EsAdmin)
                        {
                            MessageBox.Show("El intervalo es de 0 a 5 " + opcion, ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;

                case "proyectos":
                    if (canti > 0 && canti <= 3)
                    {
                        cantidad = canti;
                        if (EsAdmin)
                        {
                            MessageBox.Show("La cantidad de " + opcion + " fue aceptada", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (EsAdmin)
                        {
                            MessageBox.Show("El intervalo es de 0 a 3 " + opcion, ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;

                case "examenes":
                    if (canti > 0 && canti <= 5)
                    {
                        cantidad = canti;
                        if (EsAdmin)
                        {
                            MessageBox.Show("La cantidad de " + opcion + " fue aceptada", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (EsAdmin)
                        {
                            MessageBox.Show("El intervalo es de 0 a 5 " + opcion, ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
            }

        }

        public double porcentaje { get; set; }
        public void IngresarPorcentaje(double porcentaje1, double porcentaje2)
        {
            if (porcentaje1 == 0 && porcentaje2 == 0)
            {
                try
                {
                    porcentaje = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el porcentaje", ".::INGRESO DE PORCENTAJE::.", ">> ¡Escribe aquí el porcentaje! <<", -1, -1));

                    while (porcentaje <= 0 || porcentaje > 98)
                    {
                        porcentaje = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("El intervalo del porcentaje es de 0 a 98", ".::INGRESO DE PORCENTAJE::.", ">> ¡Escribe aquí el porcentaje! <<", -1, -1));
                    }
                    MessageBox.Show("El porcentaje fue aceptado", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Ingrese una cantidad valida", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (porcentaje1 != 0 && porcentaje2 == 0)
            {
                double limite = porcentaje1;
                try
                {
                    porcentaje = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el porcentaje", ".::INGRESO DE PORCENTAJE::.", ">> ¡Escribe aquí el porcentaje! <<", -1, -1));

                    while (porcentaje <= 0 || porcentaje > 100 - limite)
                    {
                        porcentaje = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("El intervalo del porcentaje es de 0 a " + (100 - limite), ".::INGRESO DE PORCENTAJE::.", ">> ¡Escribe aquí el porcentaje! <<", -1, -1));
                    }
                    MessageBox.Show("El porcentaje fue aceptado", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Ingrese una cantidad valida", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (porcentaje1 != 0 && porcentaje2 != 0)
            {
                double limite = porcentaje1 + porcentaje2;
                try
                {
                    porcentaje = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el porcentaje", ".::INGRESO DE PORCENTAJE::.", ">> ¡Escribe aquí el porcentaje! <<", -1, -1));

                    while (porcentaje <= 0 || porcentaje > 100 - limite)
                    {
                        porcentaje = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("El intervalo del porcentaje es de 0 a " + (100 - limite), ".::INGRESO DE PORCENTAJE::.", ">> ¡Escribe aquí el porcentaje! <<", -1, -1));
                    }
                    MessageBox.Show("El porcentaje fue aceptado", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Ingrese una cantidad valida", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public List<double> porcentajes = new List<double>();

        double notaTemp;
        public List<int> notas = new List<int>();

        public int notasIngresadas = 0;
        public void IngresarNotas()
        {
            int notaTemp;
            int i;
            for (i = notasIngresadas; i < cantidad; i++)
            {
                try
                {
                    notaTemp = new int();
                    notaTemp = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la nota #" + (i + 1) + ":", ".::INGRESO DE NOTAS::.", ">> ¡Escribe aquí la nota! <<", -1, -1));

                    while (notaTemp < 0 || notaTemp > 100)
                    {
                        notaTemp = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("El intervalo para las notas es de 0 a 100", ".::INGRESO DE NOTAS::.", ">> ¡Escribe aquí la nota! <<", -1, -1));
                    }
                    notas.Add(notaTemp);

                    MessageBox.Show("La nota fue aceptada", ".::CORRECTO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    notasIngresadas++;
                }
                catch
                {
                    i--;
                    MessageBox.Show("Ingrese una cantidad valida", ".::ERROR::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (i == cantidad)
            {
                MessageBox.Show("Se lleno la cantidad de tareas", ".::INFO::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        double nota_prefinal;
        public double calcular_preNotaFinal()
        {
            nota_prefinal = 0;
            for (int i = 0; i < notas.Count(); i++)
            {
                if (porcentajes.Count > 0)
                {
                    nota_prefinal += notas[i] * (porcentajes[i]/100);
                }
                else
                {
                    nota_prefinal += notas[i];
                }
            }
            if (porcentajes.Count == 0)
            {
                nota_prefinal = nota_prefinal * (porcentaje/100);
            }

            return nota_prefinal;
        }
    }
}
