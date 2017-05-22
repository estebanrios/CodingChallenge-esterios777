using AccesoDB.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDB._titulosServices
{
    public interface ItitulosServices
    {
        TitulosResponse GetTitulos(string cadenaBusqueda);
    }
}
