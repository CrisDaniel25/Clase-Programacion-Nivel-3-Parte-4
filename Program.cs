using System;
using Tarea_4.menu;
using Tarea_4.model.person;

namespace Tarea_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            while (true)
            {
                Menu menu = new Menu();
                menu.DisplayMenu();
            }
        }
    }
}
