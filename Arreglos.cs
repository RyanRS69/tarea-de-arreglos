using System;
using System.Transactions;

namespace Arreglos_viernes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  Ingrese cuántos elementos tendrá el vector:");
            int T = Convert.ToInt32(Console.ReadLine());
            int[] pos = new int[T]; 

            Console.WriteLine(" ");
            Console.WriteLine("Menu");
            int menu = 0;
            while (menu != 7)
            {
                Console.WriteLine(".___________________________________________________________________.                                           ");
                Console.WriteLine("|                                                                   |               *                 *          ");
                Console.WriteLine("| >Intercambiar de posicion los numeros..........................1  |              . .               ..         ");
                Console.WriteLine("| >Ordenar de menor a mayor......................................2  |             .  °.             ...          ");
                Console.WriteLine("| >Indicar si hay números repetidos en el arreglo................3  |            . °   .           ....          ");
                Console.WriteLine("| >Indicar si está ordenado de menor a mayor.....................4  |           .°     °.         ......          ");
                Console.WriteLine("| >Buscar si un número 'x' existe en la lista....................5  |          .    * °  .         2022           ");
                Console.WriteLine("| >Promediar los numeros.........................................6  |         . * °       .  Felices fiestas!   ");
                Console.WriteLine("| >Salir.........................................................7  |        . °       * ° .                  ");
                Console.WriteLine("|                                                                   |       .     *  °      .                 ");
                Console.WriteLine("|___________________________________________________________________|      .  °              .             ");
                Console.WriteLine("                                                                          . . . . . . . . . . .               ");
                Console.WriteLine("                                                                                   ....                      ");
                Console.WriteLine("                                                                                   ....                    ");
                Console.WriteLine("                                                                                   ....                      ");
                Console.WriteLine(">Ingrese el numero de la actividad que desea hacer:         ");
            
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {

                        case 1:
                            {
                                primero();
                             }
                            break;

                        case 2:
                            {
                                segundo();
                            }

                            break;

                        case 3:
                            {
                                tercero();
                            }
                            break;



                        case 4:
                            {
                                cuarto();
                            }
                            break;



                        case 5:
                            {
                                cinco();
                            }
                            break;

                        case 6:
                            {
                                ultimo();
                            }
                            break;
                          
                        case 7:
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.WriteLine("Console.WriteLine(''Nos vemos luego''); ");
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.WriteLine(">>>>>>Error, seleccione un numero disponible por favor<<<<<<");
                            break;
                    }


                    //try principal

                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Eso no existe en el contexto actual");

                }


                static void primero()
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("  .___________________________________________.");
                        Console.WriteLine("  |                                           |");
                        Console.WriteLine("  | 1.Intercambiar la posicion de los números |");
                        Console.WriteLine("  |___________________________________________|");
                        Console.WriteLine(" ");
                        Console.WriteLine("  Ingrese cuántos elementos tendrá el vector:");
                        int T = Convert.ToInt32(Console.ReadLine());                       
                        int[] pos = new int[T];
                        int nn = 1;
                        for (int n = 0; n < T; n++)
                        {
                            Console.WriteLine(Environment.NewLine);

                            Console.WriteLine("______________________");
                            Console.WriteLine("Valor de la posición " + nn++);
                            pos[n] = Convert.ToInt32(Console.ReadLine());                           

                        }
                        Console.Clear();
                        Console.WriteLine("  .___________________________________________.");
                        Console.WriteLine("  |                                           |");
                        Console.WriteLine("  | 1.Intercambiar la posicion de los números |");
                        Console.WriteLine("  |___________________________________________|");
                        Console.WriteLine(" ");
                        Console.WriteLine("Arreglo ingresado:");
                        Console.Write("{");
                        for (int i = 0; i < T; i++)
                        {
                            Console.Write(" " + pos[i] + " ");
                        }
                        Console.Write("}");
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("Arerglo invertido:");
                        Console.Write("{");
                        for (int i = T - 1; i >= 0; i--)
                        {
                            Console.Write(" " + pos[i] + " ");
                        }
                        Console.Write("}");
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("Cualquier tecla para menú");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Menu");


                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Error 404. Poner numeros existentes en el contexto, por favor.");
                    }                    
                }



                  static void segundo()
                  {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("  .___________________________________________.");
                        Console.WriteLine("  |                                           |");
                        Console.WriteLine("  | 2.Ordenar de menor a mayor                |");
                        Console.WriteLine("  |___________________________________________|");
                        Console.WriteLine(" ");
                        Console.WriteLine(" Indique con un número el tamaño de la lista:");
                        int elemntos = Convert.ToInt32(Console.ReadLine());
                        int[] ordenados = new int[elemntos];
                        int[] ar = new int[elemntos];
                        int nn = 1;
                        for (int i = 0; i < elemntos; i++)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("__________________");
                            Console.WriteLine("Valor de la posición " + nn++);

                            ar[i] = Convert.ToInt32(Console.ReadLine());
                            ordenados[i] = ar[i];
                        }
                        int auxiliar;
                        for (int i = 0; i < elemntos - 1; i++)
                        {
                            for (int ii = i + 1; ii < elemntos; ii++)
                            {
                                if (ar[i] > ar[ii])
                                {
                                    auxiliar = ar[i];
                                    ar[i] = ar[ii];
                                    ar[ii] = auxiliar;
                                }
                            }
                        }
                        Console.Clear();
                        Console.WriteLine(" ");
                        Console.WriteLine("  .___________________________________________.");
                        Console.WriteLine("  |                                           |");
                        Console.WriteLine("  | 2.Ordenar de menor a mayor                |");
                        Console.WriteLine("  |___________________________________________|");
                        Console.WriteLine(" ");
                        Console.WriteLine("Numeros desordenados:");
                        Console.Write("{");
                        for (int i = 0; i < elemntos; i++)
                        {
                            Console.Write(" " + ordenados[i] + " ");
                        }
                        Console.Write("}");
                        Console.Write(Environment.NewLine);
                        Console.WriteLine("Numeros ordenados:");
                        Console.Write("{");
                        for (int i = 0; i < elemntos; i++)
                        {
                            Console.Write(" " + ar[i] + " ");
                        }
                        Console.Write("}");
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("Cualquier tecla para menú");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Menu");
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Syntax error");
                    }
                  }
                 

                 static void tercero()
                 {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("  .___________________________________________.");
                        Console.WriteLine("  |                                           |");
                        Console.WriteLine("  | 3.Indicar si hay números iguales          |");
                        Console.WriteLine("  |___________________________________________|");
                        Console.WriteLine(" ");
                        Console.WriteLine(" Cuántos numeros tendrá la lista?:");
                        int DIM = Convert.ToInt32(Console.ReadLine());
                        int[] S = new int[DIM];
                        int[] no = new int[DIM];
                        int nn = 1;
                        for (int i = 0; i < DIM; i++)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("_____________________");
                            Console.WriteLine("Valor de la posición:" + nn++);
                            S[i] = Convert.ToInt32(Console.ReadLine());
                            no[i] = S[i];
                        }
                        int crono = 0;
                        for (int i = 0; i < DIM - 1; i++)
                        {
                            for (int j = i + 1; j < DIM; j++)
                            {
                                if (S[i] == S[j])
                                {
                                    crono++;
                                }
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("  .___________________________________________.");
                        Console.WriteLine("  |                                           |");
                        Console.WriteLine("  | 3.Indicar si hay números iguales          |");
                        Console.WriteLine("  |___________________________________________|");
                        Console.WriteLine(" ");
                        Console.WriteLine("Numeros ingresados");
                        Console.Write("{ ");
                        for (int i = 0; i < DIM; i++)
                        {
                            Console.Write(S[i] + " ");
                        }
                        Console.Write("}");
                        if (crono > 0)
                        {
                            Console.WriteLine(Environment.NewLine);
                            Console.Write("El ' ");
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
                            Console.WriteLine("' se repite en el vector");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("  .___________________________________________.");
                            Console.WriteLine("  |                                           |");
                            Console.WriteLine("  | 3.Indicar si hay números iguales          |");
                            Console.WriteLine("  |___________________________________________|");
                            Console.WriteLine(Environment.NewLine);
                            Console.Write("De los numeros del arreglo ingresado ´{");
                            for (int i = 0; i < DIM; i++)
                            {
                                Console.Write(" " + no[i] + " ");
                            }
                            Console.WriteLine("}' no hubo numeros iguales o repetidos.");

                        }
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("Cualquier tecla para menú");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Menu");
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("No existe");
                    }
                 }
                 


                static void cuarto()
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("  .___________________________________________.");
                        Console.WriteLine("  |                                           |");
                        Console.WriteLine("  | 4.Indicar si está de menor a mayor        |");
                        Console.WriteLine("  |___________________________________________|");
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingrese el tamaño de la lista");
                        int lista = Convert.ToInt32(Console.ReadLine());
                        int[] w = new int[lista];
                        int nn = 1;
                        for (int i = 0; i < lista; i++)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("__________________");
                            Console.WriteLine("Valor de la posición " + nn++);
                            w[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        int cont = 0;
                        for (int i = 0; i < lista - 1; i++)
                        {
                            if (w[i] <= w[i + 1])
                            {
                                cont++;
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("  .___________________________________________.");
                        Console.WriteLine("  |                                           |");
                        Console.WriteLine("  | 4.Indicar si está de menor a mayor        |");
                        Console.WriteLine("  |___________________________________________|");
                        Console.WriteLine(Environment.NewLine);
                        Console.Write("Los numeros del arreglo ingresado '{ ");

                        for (int i = 0; i < lista; i++)
                        {
                            Console.Write(w[i] + " ");
                        }
                        if (cont == lista - 1)
                        {
                            Console.WriteLine("}' sí están ordenados de menor a mayor");
                        }
                        else
                        {
                            Console.Write("}' no están de menor a mayor");
                            Console.WriteLine(Environment.NewLine);
                        }
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("Cualquier tecla para menú");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Menu");
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Algo salió mal");
                    }
                }






                static void cinco ()
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("  .____________________________________________________.");
                        Console.WriteLine("  |                                                    |");
                        Console.WriteLine("  | 5.Buscar si un número 'x' existe en la lista       |");
                        Console.WriteLine("  |____________________________________________________|");
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingrese elementos del arreglo:");
                        int j = Convert.ToInt32(Console.ReadLine());
                        int[] arre = new int[j];
                        int nn = 1;
                        for (int i = 0; i < j; i++)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("________________");
                            Console.WriteLine("Pon valor de la posición " + nn++);
                            arre[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("Ingresar número ´x´ que va a buscar:");
                        int g = Convert.ToInt32(Console.ReadLine());
                        int aaa = 0;
                        for (int M = 0; M < j; M++)
                        {
                            if (arre[M] == g)
                            {
                                aaa++;
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("  .____________________________________________________.");
                        Console.WriteLine("  |                                                    |");
                        Console.WriteLine("  | 5.Buscar si un número 'x' existe en el vector      |");
                        Console.WriteLine("  |____________________________________________________|");
                        Console.WriteLine(" ");
                        Console.WriteLine(" El valor que le diste a 'x' fue " + g);
                        Console.WriteLine(Environment.NewLine);
                        Console.Write(" Este es el vector hecho '{");
                        for (int i = 0; i < j; i++)
                        {
                            Console.Write(" " + arre[i] + " ");
                        }
                        if (aaa > 0)
                        {
                            Console.Write("}', y efectivamente, el número 'x', o sea el número " + g + ", sí está dentro del vector.");
                            Console.WriteLine(Environment.NewLine);
                        }
                        else
                        {
                            Console.Write("}'' y no fue posible encontrar 'x', o sea el número >" + g + "<.");
                            Console.WriteLine(Environment.NewLine);
                        }
                        Console.ReadKey();
                        Console.WriteLine("Cualquier tecla para menú");
                        Console.Clear();
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("no");
                    }
                }


                static void ultimo()
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("  .____________________________________________________.");
                        Console.WriteLine("  |                                                    |");
                        Console.WriteLine("  | 6.Buscar si un número 'x' existe en el vector      |");
                        Console.WriteLine("  |____________________________________________________|");
                        Console.WriteLine(" ");
                        Console.WriteLine("Cuántos numeros se van a promediar?");
                        int arreglo = Convert.ToInt32(Console.ReadLine());
                        int[] ve = new int[arreglo];
                        int nn = 1;
                        for (int a = 0; a < arreglo; a++)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("_________________");
                            Console.WriteLine("Valor de la posición" + nn++);
                            ve[a] = Convert.ToInt32(Console.ReadLine());
                        }
                        int ss = 0;
                        for (int a = 0; a < arreglo; a++)
                        {
                            ss = ss + ve[a];
                        }
                        int pm = ss / arreglo;
                        Console.Clear();
                        Console.WriteLine("  .____________________________________________________.");
                        Console.WriteLine("  |                                                    |");
                        Console.WriteLine("  | 6.Buscar si un número 'x' existe en el vector      |");
                        Console.WriteLine("  |____________________________________________________|");
                        Console.WriteLine(" ");
                        Console.Write("El arreglo es '{ ");
                        for (int a = 0; a < arreglo; a++)
                        {
                            Console.Write(ve[a] + " ");
                        }

                        Console.Write("}' y el promedio redondeado es " + pm);
                        Console.WriteLine(Environment.NewLine);
                        Console.ReadKey();
                        Console.WriteLine("Cualquier tecla para menú");
                        Console.Clear();
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Error sintaxico jaja");
                    }
                }





            }
        }
    }
}