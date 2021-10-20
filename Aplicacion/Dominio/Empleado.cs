namespace Dominio
{
    public class Empleado
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string Cedula {get; set;}
        public int CodigoEmpleado {get; set;}
        public NombreRol NombreRol {get; set;} /*Relacion de agregación con la clase rol en empleado*/
        public string Sucursal {get; set;}
        /*Relacion de agregación, solo se declara el atributo dentro de la clase (relacion de composición si necesita constructor)*/
        public string Password {get; set;}
        public bool AccesoReportes {get; set;}
    }
}