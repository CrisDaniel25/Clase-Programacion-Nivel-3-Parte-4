using System;
using System.ComponentModel.DataAnnotations;

namespace Tarea_4.model.person
{
    public class Person
    {
        [Key]
        public double Cedula {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string Placa {get; set;}
        public string Marca {get; set;}
        public double Latitud {get; set;}
        public double Longitud {get; set;}
        public string Descripción {get; set;}
        public bool Pago {get; set;}

        public Person() { }

        public Person(
            double cedula, string nombre, string apellido, string placa, string marca, 
            double latitud, double longitud, string descripción, bool pago
            )
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Placa = placa;
            Marca = marca;
            Latitud = latitud;
            Longitud = longitud;
            Descripción = descripción;
            Pago = pago;
        }
    }
}