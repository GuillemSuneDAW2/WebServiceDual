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
    
    public partial class Soci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Soci()
        {
            this.Inscripcions1 = new HashSet<Inscripcions1>();
        }
    
        public int Id { get; set; }
        public string nom { get; set; }
        public string cognoms { get; set; }
        public string dni { get; set; }
        public string correu { get; set; }
        public string naixement { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inscripcions1> Inscripcions1 { get; set; }
    }
}
