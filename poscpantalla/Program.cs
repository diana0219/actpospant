using System;

namespace poscpantalla
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            int posicion;


            Console.Clear();
            do
            {
                opcion = Console.ReadLine();
                for (int i = 20; i < 80; i++)
                {

                    Console.SetCursorPosition(i, 5); Console.Write("═");
                    Console.SetCursorPosition(i, 21); Console.Write("═");
                }
                for (int i = 6; i <= 20; i++)
                {
                    Console.SetCursorPosition(19, i); Console.WriteLine("║");
                    Console.SetCursorPosition(80, i); Console.WriteLine("║");
                }



                Console.SetCursorPosition(30, 10); Console.WriteLine("1.Quienes somos");
                Console.SetCursorPosition(30, 13); Console.WriteLine("2.Menu principal");
                Console.SetCursorPosition(30, 16); Console.WriteLine("3.Salir");
                posicion = int.Parse(Console.ReadLine());

                Console.Clear();
                opcion = Console.ReadLine();
                for (int i = 20; i < 80; i++)
                {

                    Console.SetCursorPosition(i, 5); Console.Write("═");
                    Console.SetCursorPosition(i, 21); Console.Write("═");
                }
                for (int i = 6; i <= 20; i++)
                {
                    Console.SetCursorPosition(19, i); Console.WriteLine("║");
                    Console.SetCursorPosition(80, i); Console.WriteLine("║");
                }
                switch (posicion)

                {
                    case 1:

                        Console.SetCursorPosition(30, 10); Console.WriteLine("Diana Sanabria");
                        Console.SetCursorPosition(30, 13); Console.WriteLine("Francisco Cifuentes");
                        Console.SetCursorPosition(30, 16); Console.WriteLine("Juan Ducuara");
                        Console.SetCursorPosition(30, 19); Console.WriteLine("Daniel Martinez");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.SetCursorPosition(30, 10); Console.WriteLine("1.Agregar un personaje");
                        Console.SetCursorPosition(30, 13); Console.WriteLine("2.Listar un personaje");
                        Console.SetCursorPosition(30, 16); Console.WriteLine("3.buscar personaje");
                        Console.SetCursorPosition(30, 19); Console.WriteLine("4.Salir al menu principal");
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.SetCursorPosition(30, 10); Console.WriteLine("Gracias por usar el programa");
                        break;
                } 
            } while (posicion != 0);

        }
    }
}

