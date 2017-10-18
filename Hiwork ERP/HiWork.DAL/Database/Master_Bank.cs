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
    
    public partial class Master_Bank
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Master_Bank()
        {
            this.Company_TransproPartner = new HashSet<Company_TransproPartner>();
            this.Master_BankAccount = new HashSet<Master_BankAccount>();
            this.Master_BankBranch = new HashSet<Master_BankBranch>();
            this.Staff_BankAccountInfo = new HashSet<Staff_BankAccountInfo>();
        }
    
        public System.Guid ID { get; set; }
        public long CountryID { get; set; }
        public Nullable<long> CurrencyID { get; set; }
        public string Code { get; set; }
        public string Name_en { get; set; }
        public string Name_jp { get; set; }
        public string Name_cn { get; set; }
        public string Name_kr { get; set; }
        public string Name_fr { get; set; }
        public string Name_tl { get; set; }
        public long CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public long UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public bool IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Company_TransproPartner> Company_TransproPartner { get; set; }
        public virtual Master_Country Master_Country { get; set; }
        public virtual Master_Currency Master_Currency { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Master_BankAccount> Master_BankAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Master_BankBranch> Master_BankBranch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff_BankAccountInfo> Staff_BankAccountInfo { get; set; }
    }
}