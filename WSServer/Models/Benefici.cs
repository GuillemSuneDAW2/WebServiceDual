//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSServer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Benefici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Benefici()
        {
            this.ActivitatDirigidas = new HashSet<ActivitatDirigida>();
        }
    
        public int Id { get; set; }
        public string descripcio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivitatDirigida> ActivitatDirigidas { get; set; }
    }
}
