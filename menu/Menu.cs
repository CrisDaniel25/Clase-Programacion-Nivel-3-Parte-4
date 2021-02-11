using System;
using System.Threading;

namespace Tarea_4.menu
{
    public class Menu
    {
        public string MenuMenssage {get; set;}

        public void DisplayMenu()
        {
            MenuMenssage = "\t\ta) Program #1 | b) Program #2 | c) Program #3 | x) Exit ";

            Console.WriteLine(MenuMenssage);
            Console.Write("\n\n ■ Ingrese una de las opciones disponibles: ");

            try { SelectOption(Convert.ToChar(Console.ReadLine().ToLower())); }
            catch (System.Exception)
            {
                Console.WriteLine("Debes introducir un personaje al mismo tiempo.");
                Console.WriteLine("\nVuelva a intentarlo....");
                Thread.Sleep(3000);
                ResetDisplay();
            }
        }

        public void SelectOption(char option)
        {
            switch (option)
            {
                case 'a':
                    Console.WriteLine("Hola Mundo");
                break;
                case 'b':
                    Console.WriteLine("Hola Mundo");
                break;
                case 'c':
                    Console.WriteLine("Hola Mundo");
                break;
                case 'x':
                    Console.WriteLine("\nGracias ... deberías volver, nos vemos luego <3.");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                break;
                default:
                break;
            }
        }

        public void ResetDisplay()
        {
            Console.Clear();
        }
    }
}