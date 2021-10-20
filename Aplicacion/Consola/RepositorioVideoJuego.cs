using System.Collections.Generic;
using System.Linq;
using Persistencia;
using Dominio;

namespace Consola
{
    public class RepositorioVideoJuego : IRepositorioVideoJuego
    {
        Conexion conn = new Conexion();

        public void guardarVideoJuego(VideoJuego juego){
            conn.VideoJuego.Add(juego);
            conn.SaveChanges();
        }

        public void eliminarVideoJuego(int id){
            var juego = conn.VideoJuego.First( e => e.Id == id);
            conn.VideoJuego.Remove(juego);
            conn.SaveChanges();
        }

        public VideoJuego actualizarVideoJuego(VideoJuego juego){
            var VideoJuegoBusqueda = conn.VideoJuego.First( e => e.Id == juego.Id);
            VideoJuegoBusqueda.Nombre = juego.Nombre;
            VideoJuegoBusqueda.Version = juego.Version;
            VideoJuegoBusqueda.Fabricante = juego.Fabricante;
            VideoJuegoBusqueda.Multiplataforma = juego.Multiplataforma;
            VideoJuegoBusqueda.PrecioCompra = juego.PrecioCompra;
            VideoJuegoBusqueda.PrecioVenta = juego.PrecioVenta;
            
            conn.SaveChanges();
            return VideoJuegoBusqueda;
        }



    }
}