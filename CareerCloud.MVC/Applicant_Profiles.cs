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
    
    public partial class Applicant_Profiles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Applicant_Profiles()
        {
            this.Applicant_Educations = new HashSet<Applicant_Educations>();
            this.Applicant_Job_Applications = new HashSet<Applicant_Job_Applications>();
            this.Applicant_Resumes = new HashSet<Applicant_Resumes>();
            this.Applicant_Skills = new HashSet<Applicant_Skills>();
            this.Applicant_Work_History = new HashSet<Applicant_Work_History>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid Login { get; set; }
        public Nullable<decimal> Current_Salary { get; set; }
        public Nullable<decimal> Current_Rate { get; set; }
        public string Currency { get; set; }
        public string Country_Code { get; set; }
        public string State_Province_Code { get; set; }
        public string Street_Address { get; set; }
        public string City_Town { get; set; }
        public string Zip_Postal_Code { get; set; }
        public byte[] Time_Stamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Applicant_Educations> Applicant_Educations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Applicant_Job_Applications> Applicant_Job_Applications { get; set; }
        public virtual Security_Logins Security_Logins { get; set; }
        public virtual System_Country_Codes System_Country_Codes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Applicant_Resumes> Applicant_Resumes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Applicant_Skills> Applicant_Skills { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Applicant_Work_History> Applicant_Work_History { get; set; }
    }
}
