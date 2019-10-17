//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INF272_F4Y.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Profile()
        {
            this.Employees = new HashSet<Employee>();
            this.Employers = new HashSet<Employer>();
            this.ProfileLocations = new HashSet<ProfileLocation>();
        }
    
        public int ProfileID { get; set; }
        public string ProfileName { get; set; }
        public string ProfileSurname { get; set; }
        public string ProfileCellNumber { get; set; }
        public string ProfileUserName { get; set; }
        public string ProfilePassword { get; set; }
        public string ProdileEmail { get; set; }
        public string PrdofileAddress { get; set; }
        public Nullable<int> Experience { get; set; }
        public int LoginUserID { get; set; }
        public bool PictureID { get; set; }
        public int GenderID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employer> Employers { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual LogIn LogIn { get; set; }
        public virtual Picture Picture { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfileLocation> ProfileLocations { get; set; }
    }
}
