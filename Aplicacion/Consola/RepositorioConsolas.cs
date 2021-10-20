using System.Collections.Generic; //Admita el List
using System.Linq; //Aceote el where y first
using Persistencia;
using Dominio;

namespace Consola
{
    public class RepositorioConsolas : IRepositorioConsolas //Relacion para implementar la clase IRepositorioConsola
    {
        Conexion conexion = new Conexion();

        public void guardarConsolas(Consolas consolas){
            conexion.Consolas.Add(consolas);
            conexion.SaveChanges();
        }

        public void eliminarConsolas(int id){
            var consolas = conexion.Consolas.First(e => e.Id == id);
            conexion.Consolas.Remove(consolas);
            conexion.SaveChanges();
        }

        public Consolas actualizarConsolas(Consolas consolas){
            var consolasBusqueda = conexion.Consolas.First(e => e.Id == consolas.Id);
            consolasBusqueda.Nombre = consolas.Nombre;
            consolasBusqueda.Version = consolas.Version;
            consolasBusqueda.Fabricante = consolas.Fabricante;
            consolasBusqueda.TipoAlmacenamiento = consolas.TipoAlmacenamiento;
            consolasBusqueda.VelocidadProcesador = consolas.VelocidadProcesador;
            consolasBusqueda.precioCompra = consolas.precioCompra;
            consolasBusqueda.precioVenta = consolas.precioVenta;
            consolasBusqueda.VideoJuego = consolas.VideoJuego;

            conexion.SaveChanges();
            return consolasBusqueda;
        }


    }

}