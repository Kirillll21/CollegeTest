//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DetskiySad.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kids
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kids()
        {
            this.Group = new HashSet<Group>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupNumber { get; set; }
        public string Adress { get; set; }
        public int FullYears { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Group> Group { get; set; }
    }
}