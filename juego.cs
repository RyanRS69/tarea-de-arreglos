using System;

namespace juego
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {
                Console.WriteLine(">Ingrese su nombre");
                string usu = Console.ReadLine();
                try
                {
                    
                    Console.WriteLine(" ");                  
                    Console.Clear();
                    Console.WriteLine(" ");
                    Console.WriteLine("Hola " + usu + ", escribe una de estas opciones en mayuscula");
                    Console.WriteLine(" ___________________________________________________  ");
                    Console.WriteLine("|                                                   |");
                    Console.WriteLine("|> 1 PAPEL                                          |");
                    Console.WriteLine("|> 2 PIEDRA                                         |");
                    Console.WriteLine("|> 3 TIJERAS                                        |");
                    Console.WriteLine("|> 4 SALIR                                          |");
                    Console.WriteLine("|___________________________________________________|");
                    Console.WriteLine(" ");

                    string opcion = Console.ReadLine();                    

                    if (opcion == "SALIR")
                    {
                        Console.Clear();
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("Gracias por entrar");
                        Console.WriteLine("Doble enter para salir");
                        Console.ReadKey();
                        break;
                    }
                    if (opcion == "PIEDRA" || opcion == "PAPEL" || opcion == "TIJERAS")
                    {
                        Random bot1 = new Random();
                        int ara = bot1.Next(0, 3);
                        string[] opcionU = new string[3];
                        opcionU[0] = ("PIEDRA");
                        opcionU[1] = ("PAPEL");
                        opcionU[2] = ("TIJERAS");
                        string bot11 = opcionU[ara];
                        Console.Clear();
                        Console.WriteLine(" ");
                        Console.WriteLine(">| La opción de " + usu + " es " + opcion +" y del bot "+ bot11);
                        Console.WriteLine(" |______________________________________________________");
                        Console.WriteLine("" );
                        if (bot11 == ("TIJERAS") && opcion == ("PAPEL"))
                        {
                            Console.WriteLine("Ganó el bot jajaj");
                            Console.WriteLine(" ");
                            Console.WriteLine("Cualquier tecla para inicio");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (bot11 == ("PAPEL") && opcion == ("PIEDRA")) 
                        {
                            Console.WriteLine("Ganó el bot jajaj");
                            Console.WriteLine(" ");
                            Console.WriteLine("Cualquier tecla para inicio");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (bot11 == ("PIEDRA") && opcion == ("TIJERA"))
                        {
                            Console.WriteLine("Ganó el bot jajaj");
                            Console.WriteLine(" ");
                            Console.WriteLine("Cualquier tecla para inicio");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (bot11 == opcion)
                        {
                            Console.WriteLine("Nadie ganó");
                            Console.WriteLine(" ");
                            Console.WriteLine("Cualquier tecla para inicio");
                            Console.ReadKey();
                            Console.Clear();
                        }    
                        else
                        {
                            Console.WriteLine(" ");                           
                            Console.WriteLine(" ");
                            Console.Write("Felicidades! Ganó" + usu + "!!");
                            Console.WriteLine("Cualquier tecla para inicio");
                            Console.ReadKey();
                            Console.Clear();
                        }                       
         
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("ERROR, verifique que sea en mayusculas o que sea la palabra correcta");
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("Cualquier tecla para reiniciar");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                catch (Exception)
                {
                    break;
                }
            }
        }
    }
}