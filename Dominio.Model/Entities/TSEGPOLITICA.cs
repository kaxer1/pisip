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
    
    public partial class TSEGPOLITICA
    {
        public decimal CCOMPANIA { get; set; }
        public string CCANAL { get; set; }
        public Nullable<decimal> LONGITUD { get; set; }
        public Nullable<decimal> DIASVALIDEZ { get; set; }
        public Nullable<decimal> DIASMENSAJEDEINVALIDEZ { get; set; }
        public Nullable<decimal> INTENTOS { get; set; }
        public Nullable<decimal> REPETICIONES { get; set; }
        public Nullable<decimal> NUMEROS { get; set; }
        public Nullable<decimal> ESPECIALES { get; set; }
        public Nullable<decimal> MINUSCULAS { get; set; }
        public Nullable<decimal> MAYUSCULAS { get; set; }
        public Nullable<decimal> TIEMPOSESION { get; set; }
    
        public virtual TGENCANALES TGENCANALES { get; set; }
        public virtual TGENCOMPANIA TGENCOMPANIA { get; set; }
    }
}
