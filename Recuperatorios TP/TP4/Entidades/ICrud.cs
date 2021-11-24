using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public interface ICrud
    {
        List<Socio> ListarSocios();
        Socio BuscarPorID(int id);
        bool EliminarSocio(int id);
        bool EditarSocio(Socio socio);
        bool GuardarSocio(Socio socio);



    }
}
