using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class TsegUsuarioDetalleViewModel
    {
        public string CUSUARIO { get; set; }
        public decimal CCOMPANIA { get; set; }
        public Nullable<decimal> OPTLOCK { get; set; }
        public string CUSUARIOING { get; set; }
        public string CUSUARIOMOD { get; set; }
        public Nullable<System.DateTime> FINGRESO { get; set; }
        public Nullable<System.DateTime> FMODIFICACION { get; set; }
        public Nullable<decimal> ESTATUS { get; set; }
        public string CCANAL { get; set; }
        public string SOBRENOMBRE { get; set; }
        public string PASSWORD { get; set; }
        public string CAMBIOPASSWORD { get; set; }
        public string OBSERVACION { get; set; }
    }
}
