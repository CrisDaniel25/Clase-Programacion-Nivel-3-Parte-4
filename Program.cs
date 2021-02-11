using System;
using Tarea_4.menu;
using Tarea_4.database.SQLite;

namespace Tarea_4
{
    class Program : Database
    {
        static void Main(string[] args)
        {
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
