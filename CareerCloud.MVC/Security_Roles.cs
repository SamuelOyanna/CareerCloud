//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CareerCloud.MVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Security_Roles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Security_Roles()
        {
            this.Security_Logins_Roles = new HashSet<Security_Logins_Roles>();
        }
    
        public System.Guid Id { get; set; }
        public string Role { get; set; }
        public bool Is_Inactive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Security_Logins_Roles> Security_Logins_Roles { get; set; }
    }
}
