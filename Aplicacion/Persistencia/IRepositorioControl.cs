using System.Collections.Generic;
using System.Linq;
using Persistencia;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioControl
    {
        public void guardarControl(Control control);
    }
}