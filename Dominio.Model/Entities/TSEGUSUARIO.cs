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
    
    public partial class TSEGUSUARIO
    {
        public string CUSUARIO { get; set; }
        public decimal CCOMPANIA { get; set; }
        public Nullable<decimal> CINTERNO { get; set; }
    
        public virtual TGENCOMPANIA TGENCOMPANIA { get; set; }
        public virtual TSEGUSUARIODETALLE TSEGUSUARIODETALLE { get; set; }
        public virtual TSEGUSUARIOSESSION TSEGUSUARIOSESSION { get; set; }
    }
}
