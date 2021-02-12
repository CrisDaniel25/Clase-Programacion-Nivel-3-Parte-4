using System;
using Tarea_4.controller.method;

namespace Tarea_4.controller.person
{
    public class PersonController
    {
        public void Add()
        {
            Console.WriteLine("\t\tAgregar una nueva persona:");
            Add add =  new Add();
            add.AddInformation();
        }

        public void Pay()
        {
            Console.WriteLine("\t\tHacer pago de la infracción:");
            Pay pay = new Pay();
            pay.PayBill();
        }

        public void Export()
        {
            Console.WriteLine("\t\tHacer Exportación de todos los casos:");
            Export export = new Export();
            export.ExportInformation();
        }
    }
}