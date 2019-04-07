//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaGestorRecursosHumanos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class empleados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public empleados()
        {
            this.entradaEmpleados = new HashSet<entradaEmpleados>();
            this.salidaEmpleado = new HashSet<salidaEmpleado>();
            this.licencias = new HashSet<licencias>();
            this.permisos = new HashSet<permisos>();
            this.vacaciones = new HashSet<vacaciones>();
        }
    
        public int id { get; set; }
        public string codigoEmpleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public Nullable<System.DateTime> fechaIngreso { get; set; }
        public Nullable<int> salario { get; set; }
        public string estado { get; set; }
        public int id_departamento { get; set; }
        public int id_cargos { get; set; }
    
        public virtual cargos cargos { get; set; }
        public virtual departamentos departamentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<entradaEmpleados> entradaEmpleados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<salidaEmpleado> salidaEmpleado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<licencias> licencias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<permisos> permisos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vacaciones> vacaciones { get; set; }
    }
}
