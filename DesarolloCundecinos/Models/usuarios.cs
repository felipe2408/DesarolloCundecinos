//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesarolloCundecinos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuarios
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Nullable<int> IdState { get; set; }
    
        public virtual cstate cstate { get; set; }
    }
}
