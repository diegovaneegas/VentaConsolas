using System.Collections.Generic;
using System.Linq;
using Persistencia;
using Dominio;

namespace Consola
{
    public class RepositorioEmpleado : IRepositorioEmpleado //IMPLEMENTA LA CLASE IRepositorioEmpleado de la capa persistencia
    {
        Conexion conexion = new Conexion(); //Hacer la conexion como atributo global
        public List<Empleado> consultarTodosAdmin(){
            return conexion.Empleados.Where(e => e.NombreRol == NombreRol.Administrador_Compras).ToList();

        }
        public void guardarEmpleado(Empleado empleado){
            conexion.Empleados.Add(empleado);
            conexion.SaveChanges();

        }
        public void eliminarEmpleado(int id){
            var empleado = conexion.Empleados.First( e => e.Id == id);
            conexion.Empleados.Remove(empleado);
            conexion.SaveChanges();

        }
        
        public Empleado actualizarEmpleado(Empleado empleado){
            var empleadoBusqueda = conexion.Empleados.First( e => e.Id == empleado.Id);
            empleadoBusqueda.Nombre = empleado.Nombre;
            empleadoBusqueda.Apellido = empleado.Apellido;
            empleadoBusqueda.Cedula = empleado.Cedula;
            empleadoBusqueda.CodigoEmpleado = empleado.CodigoEmpleado;
            empleadoBusqueda.NombreRol = empleado.NombreRol;
            empleadoBusqueda.Sucursal = empleado.Sucursal;

            conexion.SaveChanges();
            return empleadoBusqueda;
        }
    }

}
