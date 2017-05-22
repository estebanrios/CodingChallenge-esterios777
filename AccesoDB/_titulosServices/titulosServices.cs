using AccesoDB.codeFirst;
using AccesoDB.Response;
using AccesoDB.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDB._titulosServices
{
    public class titulosServices : ItitulosServices
    {
        public TitulosResponse GetTitulos(string cadenaBusqueda)
        {
            var tituloResponse = new TitulosResponse { IsValid = true };
            try
            {
                using (var context = new IOLdb())
                {
                    tituloResponse.TitulosViewModel = context.ITEM_TITULO.Where(x => x.Simbolo.Contains(cadenaBusqueda) ||
                    x.Descripcion.Contains(cadenaBusqueda) ||
                    x.ITEM_TITULO_TYPE.Descripcion.Contains(cadenaBusqueda)).Select(x => new TitulosViewModel() {
                        Simbolo = x.Simbolo,
                        Descripcion = x.Descripcion,
                        Maximo = decimal.Round(x.Maximo ?? 0, 3).ToString(),
                        Minimo = decimal.Round(x.Minimo ?? 0, 3).ToString(),
                        PrecioApertura = decimal.Round(x.PrecioApertura ?? 0, 3).ToString(),
                        UltimoCierre = decimal.Round(x.UltimoCierre ?? 0, 3).ToString(),
                        Tipo = x.ITEM_TITULO_TYPE.Descripcion
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                tituloResponse.IsValid = false;
                tituloResponse.MessageError = ex.Message;
            }

            return tituloResponse;
        }
    }
}
