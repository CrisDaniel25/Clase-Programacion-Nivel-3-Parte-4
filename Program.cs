using System;
using Tarea_4.menu;
using Tarea_4.database.SQLite;

namespace Tarea_4
{
    class Program : Database
    {
        static void Main(string[] args)
        {
            // CreateDatabase();
            // CheckedVersion();
            Console.Clear();
            Console.WriteLine("■ Ejemplo de URL para la conexión: C:\\Users\\crist\\Desktop\\Programacion III\\Tarea-4\\mydatabase.db");
            Console.Write("\n\n■ Para continuar con la aplicación, primero debe proporcionarnos la URL de conexión a la base de datos: ");
            var url = Console.ReadLine();
            connection = @"URI=file:" + url;

            while (true)
            {
                Console.Clear();
                DisplayInformation();
                Menu menu = new Menu();
                menu.DisplayMenu();
            }
        }
    }
}
