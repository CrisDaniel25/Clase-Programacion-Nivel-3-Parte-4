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
