using System.Collections.Generic; //uso listas
using Dominio; //uso de empleado en IRepositorioEmpleado

namespace Persistencia
{
    public interface IRepositorioVideoJuego
    {
        public void guardarVideoJuego(VideoJuego juego);
        public void eliminarVideoJuego(int id);
        public VideoJuego actualizarVideoJuego(VideoJuego juego);
    }
}