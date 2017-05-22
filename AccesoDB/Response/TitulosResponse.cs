using AccesoDB.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDB.Response
{
    [Serializable]
    public class TitulosResponse
    {
        public List<TitulosViewModel> TitulosViewModel { get; set; }
        public bool IsValid { get; set; }
        public string MessageError { get; set; }
    }
}
