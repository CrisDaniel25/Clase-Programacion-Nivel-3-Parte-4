using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Tarea_4.model.person;
using Tarea_4.database.SQLite;

namespace Tarea_4.controller.method
{
    public class Pay : Person
    {
        public void PayBill()
        {
            try
            {
                Console.Write("\n\n■ Ingrese la cédula de la persona: "); Cedula = Convert.ToDouble(Console.ReadLine()); 
                Console.Write("\n\n■ ¿Desea pagar la factura pendiente [S|N]?: "); 
                var option = Convert.ToChar(Console.ReadLine().ToLower());

                Pago = option == 's' ? true : false;                

                if (Pago)
                {
                    using var con = new SQLiteConnection(Database.connection);
                    con.Open();
                    using var cmd = new SQLiteCommand(con);
                    cmd.CommandText = $"UPDATE personas SET pago = @pago WHERE cedula = {Cedula};";
                    cmd.Parameters.AddWithValue("@pago", Pago);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();   
                    Thread.Sleep(3000);
                    CreateBill();
                }
                else
                {
                    Console.WriteLine("Vuelva pronto este listo para pagar... Muchas gracias");
                    Thread.Sleep(3000);
                }
            }
            catch (System.Exception) { Console.WriteLine("Error al pagar factura..."); }
        }

        public void CreateBill()
        {
            using var con = new SQLiteConnection(Database.connection);
            con.Open();

            string stm = $"SELECT * FROM personas WHERE cedula = {Cedula};";

            using var command = new SQLiteCommand(stm, con);
            using SQLiteDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                Cedula = read.GetInt64(0); 
                Nombre = read.GetString(1); 
                Apellido = read.GetString(2);
                Placa = read.GetString(3); 
                Marca = read.GetString(4); 
                Latitud = read.GetInt64(5);
                Longitud = read.GetInt64(6); 
                Descripción = read.GetString(7);
                Pago = read.GetBoolean(8);
            } 

            if(Directory.Exists(Path) == false)
            {
                Directory.CreateDirectory(Path);
            }

            try
            {
                File.WriteAllText(Path + "\\" + "bill" + ".html", html_bill());
                Console.WriteLine("\n\tEl documento se creó con éxito en " + Path + "\n");
                Thread.Sleep(3000);
            }
            catch(System.Exception) { Console.WriteLine("Error de al exportar el caso..."); Thread.Sleep(3000); }
        }
    }
}