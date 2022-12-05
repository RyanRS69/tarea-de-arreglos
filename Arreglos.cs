using System;

namespace Arreglos_viernes
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            while (menu != 7)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(".___________________________________________________________________.");
                Console.WriteLine("|                        Menu de opciones                           |");
                Console.WriteLine("|___________________________________________________________________|                                           ");
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
                Console.WriteLine(" >Seleccione número de actividad a realizar:                                       ....                      ");

                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {

                        case 1:
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
                                    int[] vecp = new int[T];
                                    int nn = 1;
                                    for (int n = 0; n < T; n++)
                                    {
                                        Console.WriteLine(Environment.NewLine);

                                        Console.WriteLine("______________________");
                                        Console.WriteLine("Valor de la posición " + nn++);
                                        vecp[n] = Convert.ToInt32(Console.ReadLine());

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
                                        Console.Write(" " + vecp[i] + " ");
                                    }
                                    Console.Write("}");
                                    Console.WriteLine(Environment.NewLine);
                                    Console.WriteLine("Arerglo invertido:");
                                    Console.Write("{");
                                    for (int i = T - 1; i >= 0; i--)
                                    {
                                        Console.Write(" " + vecp[i] + " ");
                                    }
                                    Console.Write("}");
                                    Console.WriteLine(Environment.NewLine);
                                    Console.WriteLine("Cualquier tecla para menú");
                                    Console.ReadKey();
                                    Console.Clear();


                                }
                                catch (Exception)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Error 404. Poner numeros existentes en el contexto, por favor.");
                                }
                            }
                            break;

                        case 2:
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
                                    int T = Convert.ToInt32(Console.ReadLine());
                                    int[] vecp = new int[T];
                                    int[] ar = new int[T];
                                    int nn = 1;
                                    for (int i = 0; i < T; i++)
                                    {
                                        Console.WriteLine(" ");
                                        Console.WriteLine("__________________");
                                        Console.WriteLine("Valor de la posición " + nn++);

                                        ar[i] = Convert.ToInt32(Console.ReadLine());
                                        vecp[i] = ar[i];
                                    }
                                    int auxiliar;
                                    for (int i = 0; i < T - 1; i++)
                                    {
                                        for (int ii = i + 1; ii < T; ii++)
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
                                    for (int i = 0; i < T; i++)
                                    {
                                        Console.Write(" " + vecp[i] + " ");
                                    }
                                    Console.Write("}");
                                    Console.Write(Environment.NewLine);
                                    Console.WriteLine("Numeros ordenados:");
                                    Console.Write("{");
                                    for (int i = 0; i < T; i++)
                                    {
                                        Console.Write(" " + ar[i] + " ");
                                    }
                                    Console.Write("}");
                                    Console.WriteLine(Environment.NewLine);
                                    Console.WriteLine("Cualquier tecla para menú");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                catch (Exception)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Syntax error");
                                }
                            }

                            break;

                        case 3:
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
                                    int T = Convert.ToInt32(Console.ReadLine());
                                    int[] vecp = new int[T];
                                    int[] no = new int[T];
                                    int nn = 1;
                                    for (int i = 0; i < T; i++)
                                    {
                                        Console.WriteLine(" ");
                                        Console.WriteLine("_____________________");
                                        Console.WriteLine("Valor de la posición:" + nn++);
                                        vecp[i] = Convert.ToInt32(Console.ReadLine());
                                        no[i] = vecp[i];
                                    }
                                    int crono = 0;
                                    for (int i = 0; i < T - 1; i++)
                                    {
                                        for (int j = i + 1; j < T; j++)
                                        {
                                            if (vecp[i] == vecp[j])
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
                                    for (int i = 0; i < T; i++)
                                    {
                                        Console.Write(vecp[i] + " ");
                                    }
                                    Console.Write("}");
                                    if (crono > 0)
                                    {
                                        Console.WriteLine(Environment.NewLine);
                                        Console.Write("El ' ");
                                        for (int i = 0; i < T - 1; i++)
                                        {
                                            for (int j = i + 1; j < T; j++)
                                            {
                                                if (vecp[i] == vecp[j])
                                                {
                                                    Console.Write(vecp[i] + " ");
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
                                        for (int i = 0; i < T; i++)
                                        {
                                            Console.Write(" " + no[i] + " ");
                                        }
                                        Console.WriteLine("}' no hubo numeros iguales o repetidos.");

                                    }
                                    Console.WriteLine(Environment.NewLine);
                                    Console.WriteLine("Cualquier tecla para menú");
                                    Console.ReadKey();
                                    Console.Clear();
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
                                    Console.WriteLine("  .___________________________________________.");
                                    Console.WriteLine("  |                                           |");
                                    Console.WriteLine("  | 4.Indicar si está de menor a mayor        |");
                                    Console.WriteLine("  |___________________________________________|");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Ingrese el tamaño de la lista");
                                    int T = Convert.ToInt32(Console.ReadLine());
                                    int[] vecp = new int[T];
                                    int nn = 1;
                                    for (int i = 0; i < T; i++)
                                    {
                                        Console.WriteLine(" ");
                                        Console.WriteLine("__________________");
                                        Console.WriteLine("Valor de la posición " + nn++);
                                        vecp[i] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    int cont = 0;
                                    for (int i = 0; i < T - 1; i++)
                                    {
                                        if (vecp[i] <= vecp[i + 1])
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

                                    for (int i = 0; i < T; i++)
                                    {
                                        Console.Write(vecp[i] + " ");
                                    }
                                    if (cont == T - 1)
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
                                }
                                catch (Exception)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Algo salió mal");
                                }
                            }
                            break;



                        case 5:
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
                                    int T = Convert.ToInt32(Console.ReadLine());
                                    int[] vecp = new int[T];
                                    int nn = 1;
                                    for (int i = 0; i < T; i++)
                                    {
                                        Console.WriteLine(" ");
                                        Console.WriteLine("________________");
                                        Console.WriteLine("Pon valor de la posición " + nn++);
                                        vecp[i] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    Console.WriteLine(Environment.NewLine);
                                    Console.Clear();
                                    Console.WriteLine("Ingresar número ´x´ que va a buscar:");
                                    int g = Convert.ToInt32(Console.ReadLine());
                                    int aaa = 0;
                                    for (int M = 0; M < T; M++)
                                    {
                                        if (vecp[M] == g)
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
                                    for (int i = 0; i < T; i++)
                                    {
                                        Console.Write(" " + vecp[i] + " ");
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
                            break;

                        case 6:
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
                                    int T = Convert.ToInt32(Console.ReadLine());
                                    int[] vecp = new int[T];
                                    int nn = 1;
                                    for (int a = 0; a < T; a++)
                                    {
                                        Console.WriteLine(" ");
                                        Console.WriteLine("_________________");
                                        Console.WriteLine("Valor de la posición" + nn++);
                                        vecp[a] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    int ss = 0;
                                    for (int a = 0; a < T; a++)
                                    {
                                        ss = ss + vecp[a];
                                    }
                                    int pm = ss / T;
                                    Console.Clear();
                                    Console.WriteLine("  .____________________________________________________.");
                                    Console.WriteLine("  |                                                    |");
                                    Console.WriteLine("  | 6.Buscar si un número 'x' existe en el vector      |");
                                    Console.WriteLine("  |____________________________________________________|");
                                    Console.WriteLine(" ");
                                    Console.Write("El arreglo es '{ ");
                                    for (int a = 0; a < T; a++)
                                    {
                                        Console.Write(vecp[a] + " ");
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
                            break;

                        case 7:
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.WriteLine("Console.WriteLine(''Nos vemos luego''); ");
                            Console.WriteLine("Dos veces enter para cerrar");
                            Console.ReadKey();
                            Console.Clear();
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
            }
        }
    }
}
