//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dominio.Model.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TSEGUSUARIODETALLE
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
    
        public virtual TSEGUSUARIO TSEGUSUARIO { get; set; }
    }
}
