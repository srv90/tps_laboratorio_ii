using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public interface IAdministradorFiles<T>
    {
        bool Exportar(T datos);
        bool Importar(string ruta, out T datos);
    }
}
