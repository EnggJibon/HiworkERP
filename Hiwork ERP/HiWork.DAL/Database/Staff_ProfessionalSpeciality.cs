//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HiWork.DAL.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Staff_ProfessionalSpeciality
    {
        public long ID { get; set; }
        public System.Guid StaffID { get; set; }
        public System.Guid ProfessionalID { get; set; }
        public Nullable<bool> IsSelected { get; set; }
    
        public virtual Master_EstimationSpecializedField Master_EstimationSpecializedField { get; set; }
        public virtual Staff Staff { get; set; }
    }
}