//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaGestorRecursosHumanos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class permisos
    {
        public int id_permiso { get; set; }
        public Nullable<System.DateTime> desde { get; set; }
        public Nullable<System.DateTime> hasta { get; set; }
        public string comentario { get; set; }
        public int id_empleado { get; set; }
    
        public virtual empleados empleados { get; set; }
    }
}
