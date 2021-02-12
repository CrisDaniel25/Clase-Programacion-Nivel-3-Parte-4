using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Tarea_4.model.person;
using Tarea_4.database.SQLite;

namespace Tarea_4.controller.method
{
    public class Export : Person
    {
        public void ExportInformation()
        {
            try
            {
                Console.Write("\n\n■ Ingrese la cédula de la persona del caso que quiere exportar: "); 
                Cedula = Convert.ToDouble(Console.ReadLine()); 

                using var con = new SQLiteConnection(Database.connection);
                con.Open();

                string stm = $"SELECT * FROM personas WHERE cedula = {Cedula};";

                using var cmd = new SQLiteCommand(stm, con);
                using SQLiteDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Cedula = rdr.GetInt64(0); 
                    Nombre = rdr.GetString(1); 
                    Apellido = rdr.GetString(2);
                    Placa = rdr.GetString(3); 
                    Marca = rdr.GetString(4); 
                    Latitud = rdr.GetInt64(5);
                    Longitud = rdr.GetInt64(6); 
                    Descripción = rdr.GetString(7);
                    Pago = rdr.GetBoolean(8);
                } 

                if(Directory.Exists(Path) == false)
                {
                    Directory.CreateDirectory(Path);
                }

                try
                {
                    File.WriteAllText(Path + "\\" + "file" + ".html", html_export_case());
                    Console.WriteLine("\n\tEl documento se creó con éxito en " + Path + "\n");
                    Thread.Sleep(3000);
                }
                catch(System.Exception) { Console.WriteLine("Error de al exportar el caso..."); Thread.Sleep(3000); }
            }
            catch (System.Exception){ Console.WriteLine("Error de al exportar el caso..."); Thread.Sleep(3000); }
        }
    }   
}