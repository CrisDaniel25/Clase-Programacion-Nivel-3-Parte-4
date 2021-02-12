using System;
using System.Data.SQLite;

namespace Tarea_4.database.SQLite
{
    public class Database
    {
        public static string connection = "";

        public static void CheckedVersion()
        {
            try
            {
                string connection = "Data Source=:memory:";
                string stm = "SELECT SQLITE_VERSION()";

                using var con = new SQLiteConnection(connection);
                con.Open();

                using var cmd = new SQLiteCommand(stm, con);
                string version = cmd.ExecuteScalar().ToString();

                Console.WriteLine($"SQLite version: {version}");
            }
            catch (System.Exception) { Console.WriteLine("Error de Base de Datos..."); }
        }

        public static void CreateDatabase()
        {  
            try
            {
                using var con = new SQLiteConnection(connection);
                con.Open();

                using var cmd = new SQLiteCommand(con);

                cmd.CommandText = "DROP TABLE IF EXISTS personas";
                cmd.ExecuteNonQuery();

                cmd.CommandText = @"CREATE TABLE personas(Cedula numeric PRIMARY KEY, Nombre varchar(255), Apellido varchar(255), 
                        Placa varchar(255), Marca varchar(255), Latitud numeric, Longitud numeric, Descripción varchar(255), Pago boolean)";
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception) { Console.WriteLine("Error de Base de Datos..."); }
        }

        public static void DisplayInformation()
        {
            try
            {
                using var con = new SQLiteConnection(connection);
                con.Open();

                string stm = "SELECT * FROM personas";

                using var cmd = new SQLiteCommand(stm, con);
                using SQLiteDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    var pay = rdr.GetBoolean(8) ? "Si" : "No";

                    Console.WriteLine($"\nCedula: {rdr.GetInt64(0)} | Nombre: {rdr.GetString(1)} | Apellido: {rdr.GetString(2)} | " + 
                                      $"Placa: {rdr.GetString(3)} | Marca: {rdr.GetString(4)} | Latitud: {rdr.GetInt64(5)} | " +
                                      $"Longitud: {rdr.GetInt64(6)} | Descripción: {rdr.GetString(7)} | Pago: {pay}");
                }    
            }
            catch (System.Exception) { Console.WriteLine("Ningun registro encontrado..."); }        
        }
    }
}