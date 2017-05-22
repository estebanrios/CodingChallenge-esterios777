using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDB.ViewModel
{
    [Serializable]
    public class TitulosViewModel
    {
        public string Simbolo { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public string PrecioApertura { get; set; }
        public string Minimo { get; set; }
        public string Maximo { get; set; }
        public string UltimoCierre { get; set; }
    }
}
