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
    
    public partial class departamentos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public departamentos()
        {
            this.empleados = new HashSet<empleados>();
        }
    
        public int id_departamento { get; set; }
        public string codigoDepartamento { get; set; }
        public string nombre { get; set; }
        public string encargado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<empleados> empleados { get; set; }
    }
}
