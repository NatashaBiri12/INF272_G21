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
    
    public partial class Skill
    {
        public int SkillID { get; set; }
        public string SkillDescription { get; set; }
        public int RequiredID { get; set; }
    
        public virtual Required Required { get; set; }
    }
}
