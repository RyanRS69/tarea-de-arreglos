using System;

namespace Arreglos_P
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un número de caso (del 1 al 7 por favor):");
            int opcion = 0;

                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("1) Intercambiar de posicion los numeros");
                Console.WriteLine("2) Decir si está ordenado de menor a mayor");
                Console.WriteLine("3) Verificar si hay numeros iguales en el arreglo");
                Console.WriteLine("4) Ordenar el arreglo de menor a mayor");
                Console.WriteLine("5) Buscar si existe un numero elegido en el arreglo");
                Console.WriteLine("6) Promediar los numeros");
                Console.WriteLine("7) Apagar ._.");
                Console.WriteLine(Environment.NewLine);

                Console.WriteLine("----------");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("Seleccion: Cambiar posicion de numeros derecha a izquierda.");
                                    Console.WriteLine("----------------------------");
                                    Console.WriteLine("Defina el tamaño del arreglo");
                                    int DM = Convert.ToInt32(Console.ReadLine());
                                    int[] B = new int[DM];
                                    for (int n = 0; n < DM; n++)
                                    {
                                        Console.WriteLine("Ingrese un numero");
                                        B[n] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    Console.WriteLine("El z original es: ");
                                    for (int i = 0; i < DM; i++)
                                    {
                                        Console.Write(B[i] + " ");
                                    }
                                    Console.WriteLine("\nEl z invertido es: ");
                                    for (int i = DM - 1; i >= 0; i--)
                                    {
                                        Console.Write(B[i] + " ");
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Poner numeros existentes en el contexto, por favor.");
                                }
                            }
                            break;
                        case 2:
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("Seleccion: Verificar si estará de menor a mayor");
                                    Console.WriteLine("----------------------------");
                                    Console.WriteLine("Ingrese el tamaño de la lista");
                                    int L = Convert.ToInt32(Console.ReadLine());
                                    int[] z = new int[L];
                                    for (int i = 0; i < L; i++)
                                    {
                                        Console.WriteLine("Ingrese un numero");
                                        z[i] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    int cont = 0;
                                    for (int i = 0; i < L - 1; i++)
                                    {
                                        if (z[i] <= z[i + 1])
                                        {
                                            cont++;
                                        }
                                    }
                                    Console.WriteLine("Valores elegidos:");
                                    for (int i = 0; i < L; i++)
                                    {
                                        Console.Write(z[i] + " ");
                                    }
                                    if (cont == L - 1)
                                    {
                                        Console.WriteLine(Environment.NewLine);
                                        Console.WriteLine("Sí está ordenada");
                                    }
                                    else
                                    {
                                        Console.WriteLine(Environment.NewLine);
                                        Console.WriteLine("No está de menoa a mayor");
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Presione cualquier tecla para reiniciar");
                                }
                            }
                            break;
                        case 3:
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("Seleccion: Verificiar si hay numeros iguales");
                                    Console.WriteLine("-------------------------");
                                    Console.WriteLine(" Cuantos numeros tendrá?:");
                                    int DIM = Convert.ToInt32(Console.ReadLine());
                                    int[] S = new int[DIM];
                                    for (int i = 0; i < DIM; i++)
                                    {
                                        Console.WriteLine("Ingresar valor:");
                                        S[i] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    int W = 0;
                                    for (int i = 0; i < DIM - 1; i++)
                                    {
                                        for (int j = i + 1; j < DIM; j++)
                                        {
                                            if (S[i] == S[j])
                                            {
                                                W++;
                                            }
                                        }
                                    }
                                    Console.WriteLine("El arreglo es:");
                                    for (int i = 0; i < DIM; i++)
                                    {
                                        Console.WriteLine(S[i] + " ");
                                    }
                                    if (W > 0)
                                    {
                                        Console.WriteLine(Environment.NewLine);
                                        Console.WriteLine("se detectó un numero repetido");
                                        for (int i = 0; i < DIM - 1; i++)
                                        {
                                            for (int j = i + 1; j < DIM; j++)
                                            {
                                                if (S[i] == S[j])
                                                {
                                                    Console.Write(S[i] + " ");
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(Environment.NewLine);
                                        Console.Clear();
                                        Console.WriteLine("No hay numeros iguales");
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.Clear();
                                    Console.WriteLine("No existe");
                                }
                            }
                            break;
                        case 4:
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("Seleccion: Ordenar de menor a mayor");
                                    Console.WriteLine("-------------------");
                                    Console.WriteLine("Tamaño del arreglo:");
                                    int P = Convert.ToInt32(Console.ReadLine());
                                    int[] W = new int[P];
                                    for (int i = 0; i < P; i++)
                                    {
                                        Console.WriteLine("Escribe un valor:");
                                        W[i] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    int o;
                                    for (int i = 0; i < P - 1; i++)
                                    {
                                        for (int j = i + 1; j < P; j++)
                                        {
                                            if (W[i] > W[j])
                                            {
                                                o = W[i];
                                                W[i] = W[j];
                                                W[j] = o;
                                            }
                                        }
                                    }
                                    Console.WriteLine(Environment.NewLine);
                                    Console.WriteLine("Numeros ordenados:");
                                    for (int i = 0; i < P; i++)
                                    {
                                        Console.Write(W[i] + " ");
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.Clear();
                                    Console.WriteLine("NO EXISTEE");
                                }
                            }
                            break;
                        case 5:
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("Seleccion: Se buscará si existe un numero especifico en el arreglo");
                                    Console.WriteLine("-------------------------------");
                                    Console.WriteLine("Numero de elementos del arreglo:");
                                    int j = Convert.ToInt32(Console.ReadLine());
                                    int[] q = new int[j];
                                    for (int i = 0; i < j; i++)
                                    {
                                        Console.WriteLine("Ingrese un valor");
                                        q[i] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    Console.WriteLine("Ingrese numero a buscar:");
                                    int g = Convert.ToInt32(Console.ReadLine());
                                    int aaa = 0;
                                    for (int i = 0; i < j; i++)
                                    {
                                        if (q[i] == g)
                                        {
                                            aaa++;
                                        }
                                    }
                                    Console.WriteLine("Los valores son");
                                    for (int i = 0; i < j; i++)
                                    {
                                        Console.Write(q[i] + " ");
                                    }
                                    if (aaa > 0)
                                    {
                                        Console.WriteLine(Environment.NewLine);
                                        Console.WriteLine("efectivamente está el numero" + g );
                                    }
                                    else
                                    {
                                        Console.WriteLine(Environment.NewLine);
                                        Console.WriteLine("No fue posible entonctrar " + g );
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.Clear();
                                    Console.WriteLine("no");
                                }
                            }
                            break;
                        case 6:
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("Seleccion: El promedio de lo ingresado");
                                    Console.WriteLine("-------------------");
                                    Console.WriteLine("Valores a promediar:");
                                    int d = Convert.ToInt32(Console.ReadLine());
                                    int[] v = new int[d];
                                    for (int a = 0; a < d; a++)
                                    {
                                        Console.WriteLine("Ingrese un numero");
                                        v[a] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    int Z = 0;
                                    for (int a = 0; a < d; a++)
                                    {
                                        Z = Z + v[a];
                                    }
                                    int pm = Z / d;
                                    Console.WriteLine("La lista de numeros ingresada es: ");
                                    for (int a = 0; a < d; a++)
                                    {
                                        Console.Write(v[a] + " ");
                                    }
                                    Console.WriteLine(Environment.NewLine);
                                    Console.WriteLine("Promedio de los valores:" + pm);
                                }
                                catch (Exception)
                                {Console.Clear();
                                    Console.WriteLine("Error sintaxico jaja");
                                }
                                break;
                            }
                        case 7:
                            Console.Clear();
                            Console.WriteLine(Environment.NewLine);
                            Console.WriteLine(Environment.NewLine);
                            Console.WriteLine("Nos vemos luego :)");
                            Console.WriteLine("---------------");
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Esa opcion no existe en el contexto actual!!!!");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Algo salio mal!!! :(");
                }
        } 
    }
}