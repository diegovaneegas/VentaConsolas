using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioConsolas
    {
        public void guardarConsolas(Consolas consolas);
        public void eliminarConsolas(int id);
        public Consolas actualizarConsolas(Consolas consolas);
    }
}