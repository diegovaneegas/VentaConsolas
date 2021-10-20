using System.Collections.Generic;
using System.Linq;
using Persistencia;
using Dominio;

namespace Consola
{
    public class RepositorioControl : IRepositorioControl
    {
        Conexion conexion = new Conexion();
        public void guardarControl(Control control){
            conexion.Control.Add(control);
            conexion.SaveChanges();
        }
    
    }

}