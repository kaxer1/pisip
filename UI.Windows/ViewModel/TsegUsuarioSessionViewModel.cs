using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class TsegUsuarioSessionViewModel
    {
        public string CUSUARIO { get; set; }
        public decimal CCOMPANIA { get; set; }
        public Nullable<decimal> NUMEROINTENTOS { get; set; }
        public string IDSESSION { get; set; }
        public Nullable<System.DateTime> FINICIO { get; set; }
        public Nullable<System.DateTime> FSALIDA { get; set; }
        public string ACTIVO { get; set; }
        public Nullable<decimal> TIEMPOSESION { get; set; }
        public Nullable<System.DateTime> FULTIMAACCION { get; set; }
        public string CESTADO { get; set; }
        public string USERAGENT { get; set; }
        public string CTERMINALREMOTO { get; set; }

    }
}
