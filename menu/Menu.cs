using System;
using System.Threading;
using Tarea_4.controller.person;

namespace Tarea_4.menu
{
    public class Menu : PersonController
    {
        public string MenuMenssage {get; set;}

        public void DisplayMenu()
        {
            MenuMenssage = "\n\n\t\ta) Agregar | b) Pagar | c) Exportar Caso | x) Salir ";

            Console.WriteLine(MenuMenssage);
            Console.Write("\n\n ■ Ingrese una de las opciones disponibles: ");

            try { SelectOption(Convert.ToChar(Console.ReadLine().ToLower())); }
            catch (System.Exception)
            {
                Console.WriteLine("Debes introducir un carácter al mismo tiempo.");
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
                    ResetDisplay();
                    Add();
                break;
                case 'b':
                    ResetDisplay();
                    Pay();
                break;
                case 'c':
                    ResetDisplay();
                    Export();
                break;
                case 'x':
                    Console.WriteLine("\nGracias ... deberías volver, nos vemos luego <3.");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                break;
                default:
                    Console.WriteLine("\nLa opción que eliges no está disponible ... inténtalo de nuevo gracias <3");
                    Thread.Sleep(3000);
                    ResetDisplay();
                break;
            }
        }

        public void ResetDisplay() { Console.Clear(); }
    }
}