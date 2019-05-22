//Librerias.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ColegiosUnidos
{
    static class Ordenamientos
    {
        public static int comparaciones=0;
        public static int asignaciones=0;

        static public List<Estudiante> Burbuja(List<Estudiante> arr, string parametro, bool EsAscendente)
        {
            Estudiante temp;

            if (EsAscendente)
            {
                for (int write = 0; write < arr.Count; write++)
                {
                    for (int sort = 0; sort < arr.Count - 1; sort++)
                    {
                        comparaciones++;
                        if (Recursos.Ordenador<Estudiante>(arr, parametro, sort, sort + 1) > 0)
                        {
                            temp = arr[sort + 1];
                            arr[sort + 1] = arr[sort];
                            arr[sort] = temp;
                            asignaciones++;
                        }
                    }
                }
                return arr;
            }
            else
            {
                for (int write = 0; write < arr.Count; write++)
                {
                    for (int sort = 0; sort < arr.Count - 1; sort++)
                    {
                        comparaciones++;
                        if (Recursos.Ordenador<Estudiante>(arr, parametro, sort, sort + 1) < 0)
                        {
                            temp = arr[sort + 1];
                            arr[sort + 1] = arr[sort];
                            arr[sort] = temp;
                            asignaciones++;
                        }
                    }
                }
                return arr;
            }
        }

        static public List<Estudiante> Insercion(List<Estudiante> arr, string parametro, bool EsAscendente)
        {
            if (EsAscendente)
            {
                Estudiante temp;

                for (int i = 0; i < arr.Count() - 1; i++)
                {
                    for (int j = i + 1; j > 0; j--)
                    {
                        comparaciones++;
                        if (Recursos.Ordenador<Estudiante>(arr, parametro, j - 1, j) > 0)
                        {
                            temp = arr[j - 1];
                            arr[j - 1] = arr[j];
                            arr[j] = temp;
                            asignaciones++;
                        }
                    }
                }
                return arr;
            }
            else
            {
                Estudiante temp;

                for (int i = 0; i < arr.Count() - 1; i++)
                {
                    for (int j = i + 1; j > 0; j--)
                    {
                        comparaciones++;
                        if (Recursos.Ordenador<Estudiante>(arr, parametro, j - 1, j) < 0)
                        {
                            temp = arr[j - 1];
                            arr[j - 1] = arr[j];
                            arr[j] = temp;
                            asignaciones++;
                        }
                    }
                }
                return arr;
            }
        }

        static public List<Estudiante> Seleccion(List<Estudiante> arr, string parametro, bool EsAscendente)
        {
            int posicionValorMinimo;
            Estudiante temp;

            if (EsAscendente)
            {
                for (int i = 0; i < arr.Count() - 1; i++)
                {
                    //Suponemos que el valor mínimo está en esta posición.
                    posicionValorMinimo = i;

                    //Iteramos entre el resto de los elementos.
                    for (int j = i + 1; j < arr.Count(); j++)
                    {
                        comparaciones++;
                        //Si este elemento es menor que el que habíamos tomado.
                        if (Recursos.Ordenador<Estudiante>(arr, parametro, j, posicionValorMinimo) < 0)
                        {
                            //Indicamos la posición del nuevo elemento más chico.
                            posicionValorMinimo = j;
                        }
                    }
                    //Si encontramos un número menor que el tomado al principio.
                    if (i != posicionValorMinimo)
                    {
                        //Intercambiamos sus lugares.
                        temp = arr[i];
                        arr[i] = arr[posicionValorMinimo];
                        arr[posicionValorMinimo] = temp;
                        asignaciones++;
                    }
                }
                return arr;
            }
            else
            {
                for (int i = 0; i < arr.Count() - 1; i++)
                {
                    //Suponemos que el valor mínimo está en esta posición.
                    posicionValorMinimo = i;

                    //Iteramos entre el resto de los elementos.
                    for (int j = i + 1; j < arr.Count(); j++)
                    {
                        comparaciones++;
                        //Si este elemento es mayor que el que habíamos tomado.
                        if (Recursos.Ordenador<Estudiante>(arr, parametro, j, posicionValorMinimo) < 0)
                        {
                            //Indicamos la posición del nuevo elemento más chico.
                            posicionValorMinimo = j;
                        }
                    }
                    //Si encontramos un número menor que el tomado al principio.
                    if (i != posicionValorMinimo)
                    {
                        //Intercambiamos sus lugares.
                        temp = arr[i];
                        arr[i] = arr[posicionValorMinimo];
                        arr[posicionValorMinimo] = temp;
                        asignaciones++;
                    }
                }
                return arr;
            }
        }

        static public List<Estudiante> Shell(List<Estudiante> arr, string parametro, bool EsAscendente)
        {
            if (EsAscendente)
            {
                Estudiante temp;

                int salto = 0;
                int sw = 0;
                int e = 0;

                salto = arr.Count() / 2;
                while (salto > 0)
                {
                    sw = 1;
                    while (sw != 0)
                    {
                        sw = 0;
                        e = 1;
                        while (e <= (arr.Count() - salto))
                        {
                            comparaciones++;
                            if (Recursos.Ordenador<Estudiante>(arr, parametro, e - 1, (e - 1) + salto) > 0)
                            {
                                temp = arr[(e - 1) + salto];
                                arr[(e - 1) + salto] = arr[e - 1];
                                arr[(e - 1)] = temp;
                                sw = 1;
                                asignaciones++;
                            }
                            e++;
                        }
                    }
                    salto = salto / 2;
                }
                return arr;
            }
            else
            {
                Estudiante temp;

                int salto = 0;
                int sw = 0;
                int e = 0;

                salto = arr.Count() / 2;
                while (salto > 0)
                {
                    sw = 1;
                    while (sw != 0)
                    {
                        sw = 0;
                        e = 1;
                        while (e <= (arr.Count() - salto))
                        {
                            comparaciones++;
                            if (Recursos.Ordenador<Estudiante>(arr, parametro, e - 1, (e - 1) + salto) < 0)
                            {
                                temp = arr[(e - 1) + salto];
                                arr[(e - 1) + salto] = arr[e - 1];
                                arr[(e - 1)] = temp;
                                sw = 1;
                                asignaciones++;
                            }
                            e++;
                        }
                    }
                    salto = salto / 2;
                }
                return arr;
            }
        }

        static public List<Estudiante> Quick(List<Estudiante> arr, int left, int right, string parametro, bool EsAscendente)
        {
            if (EsAscendente)
            {
                if (left < right)
                {
                    int q = Recursos.ParticionAsc(arr, left, right, parametro);
                    Quick(arr, left, q - 1, parametro, EsAscendente);
                    Quick(arr, q + 1, right, parametro, EsAscendente);
                }
                return arr;
            }
            else
            {
                if (left < right)
                {
                    int q = Recursos.ParticionDes(arr, left, right, parametro);
                    Quick(arr, left, q - 1, parametro, EsAscendente);
                    Quick(arr, q + 1, right, parametro, EsAscendente);
                }
                return arr;
            }
        }

        static public List<Estudiante> Mezcla(Estudiante[] arregloEstudiantes, int left, int right, string parametro, bool EsAscendente)
        {
            if (EsAscendente)
            {
                if (left < right)
                {
                    int middle = (left + right) / 2;

                    Mezcla(arregloEstudiantes, left, middle, parametro, EsAscendente);
                    Mezcla(arregloEstudiantes, middle + 1, right, parametro, EsAscendente);

                    Estudiante[] leftArray = new Estudiante[middle - left + 1];
                    Estudiante[] rightArray = new Estudiante[right - middle];

                    Array.Copy(arregloEstudiantes, left, leftArray, 0, middle - left + 1);
                    Array.Copy(arregloEstudiantes, middle + 1, rightArray, 0, right - middle);

                    int i = 0;
                    int j = 0;

                    for (int k = left; k < right + 1; k++)
                    {
                        comparaciones++;
                        if (i == leftArray.Length)
                        {
                            arregloEstudiantes[k] = rightArray[j];
                            j++;
                        }
                        else if (j == rightArray.Length)
                        {
                            arregloEstudiantes[k] = leftArray[i];
                            i++;
                        }
                        else if (Recursos.OrdenadorVector<Estudiante>(leftArray, i, rightArray, j, parametro) < 0)
                        {
                            arregloEstudiantes[k] = leftArray[i];
                            i++;
                            asignaciones++;
                        }
                        else
                        {
                            arregloEstudiantes[k] = rightArray[j];
                            j++;
                        }
                    }
                }
                return arregloEstudiantes.ToList<Estudiante>();
            }
            else
            {
                if (left < right)
                {
                    int middle = (left + right) / 2;

                    Mezcla(arregloEstudiantes, left, middle, parametro, EsAscendente);
                    Mezcla(arregloEstudiantes, middle + 1, right, parametro, EsAscendente);

                    Estudiante[] leftArray = new Estudiante[middle - left + 1];
                    Estudiante[] rightArray = new Estudiante[right - middle];

                    Array.Copy(arregloEstudiantes, left, leftArray, 0, middle - left + 1);
                    Array.Copy(arregloEstudiantes, middle + 1, rightArray, 0, right - middle);

                    int i = 0;
                    int j = 0;

                    for (int k = left; k < right + 1; k++)
                    {
                        if (i == leftArray.Length)
                        {
                            arregloEstudiantes[k] = rightArray[j];
                            j++;
                        }
                        else if (j == rightArray.Length)
                        {
                            arregloEstudiantes[k] = leftArray[i];
                            i++;
                        }
                        else if (Recursos.OrdenadorVector<Estudiante>(leftArray, i, rightArray, j, parametro) > 0)
                        {
                            arregloEstudiantes[k] = leftArray[i];
                            i++;
                        }
                        else
                        {
                            arregloEstudiantes[k] = rightArray[j];
                            j++;
                        }
                    }
                }
                return arregloEstudiantes.ToList<Estudiante>();
            }
        }

        static class Recursos
        {
            public static int Ordenador<TipoLista>(List<TipoLista> nombre, string NombrePropiedad, int indice, int indice2)
            {
                object objeto = (object)nombre[0];
                PropertyInfo Informacion = objeto.GetType().GetProperty(NombrePropiedad);

                object primero = Informacion.GetValue((object)nombre[indice], null);
                object segundo = Informacion.GetValue((object)nombre[indice2], null);

                int a = CompararValores(primero, segundo);
                return a;
            }

            public static int OrdenadorVector<TipoVector>(TipoVector[] nombre1, int indice1, TipoVector[] nombre2, int indice2,string NombrePropiedad)
            {
                object objeto = (object)nombre1[0];
                object objeto2 = (object)nombre2[0];
                PropertyInfo Informacion = objeto.GetType().GetProperty(NombrePropiedad);

                object primero = Informacion.GetValue((object)nombre1[indice1], null);
                object segundo = Informacion.GetValue((object)nombre2[indice2], null);

                int a = CompararValores(primero, segundo);
                return a;
            }

            public static int CompararValores(object valor, object valor2)
            {
                IComparable Comparador;
                Comparador = valor as IComparable;
                return Comparador.CompareTo(valor2);
            }

            public static int ParticionAsc(List<Estudiante> arr, int left, int rigth, string parametro)
            {
                Estudiante pivote = arr[rigth];
                int Ppivote = rigth;
                Estudiante temp;

                int i = left;
                for (int j = left; j < rigth; j++)
                {
                    Ordenamientos.comparaciones++;
                    if (Recursos.Ordenador<Estudiante>(arr, parametro, j, Ppivote) < 0)
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                        i++;
                        Ordenamientos.asignaciones++;
                    }
                }
                arr[rigth] = arr[i];
                arr[i] = pivote;

                return i;
            }

            public static int ParticionDes(List<Estudiante> arr, int left, int rigth, string parametro)
            {
                Estudiante pivote = arr[rigth];
                int Ppivote = rigth;
                Estudiante temp;

                int i = left;
                for (int j = left; j < rigth; j++)
                {
                    Ordenamientos.comparaciones++;
                    if (Recursos.Ordenador<Estudiante>(arr, parametro, j, Ppivote) > 0)
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                        i++;
                        Ordenamientos.asignaciones++;
                    }
                }
                arr[rigth] = arr[i];
                arr[i] = pivote;

                return i;
            }
        }
    }
}