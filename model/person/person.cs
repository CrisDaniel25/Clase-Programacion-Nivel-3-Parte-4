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

        public string Path = "C:\\html";

        public string html_export_case()
        {
            var result = Pago == true ? "Si" : "No";

            return  "<html>" +
            "<head>" +
            "<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>" +
            "</head>" +
            "<body>" +
            "<table class='table table-striped table - dark'>" +
            "<thead>" +
            "<tr>" + 
            "<th scope='col'>" + "Cédula:" + "</th>" +
            "<th scope='col'>" + "Nombre:" + "</th>" +
            "<th scope='col'>" + "Apellido:" + "</th>" +
            "<th scope='col'>" + "Placa de el Vehículo:" + "</th>" +
            "<th scope='col'>" + "Marca de el Vehículo:" + "</th>" +
            "<th scope='col'>" + "Latitud del hecho:" + "</th>" +
            "<th scope='col'>" + "Longitud del hecho:" + "</th>" +
            "<th scope='col'>" + "Descripción:" + "</th>" +
            "<th scope='col'>" + "¿Factura ha sido paga?:" + "</th>" +
            "</tr>" +
            "</thead>" +
            "<tbody>" +
            "<tr>" +
            "<th>" + Cedula + "</th>" +
            "<th>" + Nombre + "</th>" +
            "<th>" + Apellido + "</th>" +
            "<th>" + Placa + "</th>" +
            "<th>" + Marca + "</th>" +
            "<th>" + Latitud + "</th>" +
            "<th>" + Longitud + "</th>" +
            "<th>" + Descripción + "</th>" +
            "<th>" + result + "</th>" +
            "</tr>" +
            "</tbody>" +
            "</table>" +
            "</body>" +
            "</html>";
        }

        public string html_bill()
        {
            DateTime localDate = DateTime.Now;
            return  "<html>" +
            "<head>" +
            "<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>" +
            "</head>" +
            "<body>" +
            "<table class='table table-striped table - dark'>" +
            "<thead>" +
            "<tr>" + 
            "<th scope='col'>" + "Cédula:" + "</th>" +
            "<th scope='col'>" + "Nombre:" + "</th>" +
            "<th scope='col'>" + "Apellido:" + "</th>" +
            "<th scope='col'>" + "Fecha de Pago:" + "</th>" +
            "<th scope='col'>" + "Placa de el Vehículo:" + "</th>" +
            "<th scope='col'>" + "Marca de el Vehículo:" + "</th>" +
            "<th scope='col'>" + "Descripción de la violación a pagar:" + "</th>" +
            "</tr>" +
            "</thead>" +
            "<tbody>" +
            "<tr>" +
            "<th>" + Cedula + "</th>" +
            "<th>" + Nombre + "</th>" +
            "<th>" + Apellido + "</th>" +
            "<th>" + localDate + "</th>" +
            "<th>" + Placa + "</th>" +
            "<th>" + Marca + "</th>" +
            "<th>" + Descripción + "</th>" +
            "</tr>" +
            "</tbody>" +
            "</table>" +
            "</body>" +
            "</html>";
        }
    }
}