using System.Collections.Generic; //uso listas
using Dominio; //uso de empleado en IRepositorioEmpleado

namespace Persistencia
{
    public interface IRepositorioEmpleado //CUBRIENDO EL CRUD DE UNA ENTIDAD
    {
        public List<Empleado> consultarTodosAdmin();
        public void guardarEmpleado(Empleado empleado);
        public void eliminarEmpleado(int id);
        public Empleado actualizarEmpleado(Empleado empleado);
        
    }
}