using System;
using System.Threading;
using System.Data.SQLite;
using Tarea_4.model.person;
using Tarea_4.database.SQLite;

namespace Tarea_4.controller.method
{
    public class Add : Person
    {
        public void AddInformation()
        {
            try
            {
                Console.Write("\n\n■ Ingrese la cédula de la persona: "); Cedula = Convert.ToDouble(Console.ReadLine()); 
                Console.Write("\n\n■ Ingrese el nombre de la persona: "); Nombre = Console.ReadLine(); 
                Console.Write("\n\n■ Ingrese el apellido de la persona: "); Apellido = Console.ReadLine();
                Console.Write("\n\n■ Ingrese la placa: "); Placa = Console.ReadLine(); 
                Console.Write("\n\n■ Ingrese la marca: "); Marca = Console.ReadLine();
                Console.Write("\n\n■ Ingrese la latitud del hecho: "); Latitud = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n\n■ Ingrese la longitud del hecho: "); Longitud = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n\n■ Ingrese su descripción: "); Descripción = Console.ReadLine();
                Pago = false;

                Database connection = new Database();
                using var con = new SQLiteConnection(connection.connection);
                con.Open();
                using var cmd = new SQLiteCommand(con);
                cmd.CommandText = "INSERT INTO personas(cedula, nombre, apellido, placa, marca, latitud, longitud, descripción, pago) " +
					              "VALUES(@cedula, @nombre, @apellido, @placa, @marca, @latitud," + 
                                  "@longitud, @descripción, @pago);";
                cmd.Parameters.AddWithValue("@cedula", Cedula);
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@apellido", Apellido);
                cmd.Parameters.AddWithValue("@placa", Placa);
                cmd.Parameters.AddWithValue("@marca", Marca);
                cmd.Parameters.AddWithValue("@latitud", Latitud);
                cmd.Parameters.AddWithValue("@longitud", Longitud);
                cmd.Parameters.AddWithValue("@descripción", Descripción);
                cmd.Parameters.AddWithValue("@pago", Pago);
                cmd.Prepare();
                cmd.ExecuteNonQuery();                
            }
            catch (System.Exception) { Console.WriteLine("Error al introducir los datos de la persona..."); }
        }        
    }   
}