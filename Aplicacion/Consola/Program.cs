using System;
using System.Linq;
using Dominio;
using Persistencia;

        /* dotnet ef migrations add AgregarTablaControles --startup-project ..\Consola\     */
        /*dotnet ef database update --startup-project ..\Consola\               */
        //GUARDAR CAMBIOS EN LA BASE DE DATOS
            //Conexion conn = new Conexion();
            //conn.Consolas.Add(cs);
            //conn.SaveChanges();

namespace Consola
{
    class Program
    {
        static void Main(string[] args){
            
            Conexion conexion = new Conexion();
            Control cl = new Control();
            cl.Nombre ="Bicho";
            cl.Serial= 6609;
            cl.FechaCompra= "4 de octubre";
            cl.precioCompra = 50000;
            cl.precioVenta = 100000; 

            conexion.Control.Add(cl);
            conexion.SaveChanges();
        }
    }
}
