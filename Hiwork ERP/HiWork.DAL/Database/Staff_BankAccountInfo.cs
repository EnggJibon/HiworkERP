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
    
    public partial class Staff_BankAccountInfo
    {
        public System.Guid ID { get; set; }
        public System.Guid StaffID { get; set; }
        public System.Guid BankID { get; set; }
        public System.Guid BankBranchID { get; set; }
        public long AccountTypeID { get; set; }
        public string AccountHolderName_en { get; set; }
        public string AccountHolderName_jp { get; set; }
        public string AccountHolderName_kr { get; set; }
        public string AccountHolderName_cn { get; set; }
        public string AccountHolderName_fr { get; set; }
        public string AccountHolderName_tl { get; set; }
        public string AccountNo { get; set; }
        public string AccountHolderAddress_en { get; set; }
        public string AccountHolderAddress_jp { get; set; }
        public string AccountHolderAddress_kr { get; set; }
        public string AccountHolderAddress_cn { get; set; }
        public string AccountHolderAddress_fr { get; set; }
        public string AccountHolderAddress_tl { get; set; }
        public string AccountHolderContactNo { get; set; }
        public string AccountNote_en { get; set; }
        public string AccountNote_jp { get; set; }
        public string AccountNote_kr { get; set; }
        public string AccountNote_cn { get; set; }
        public string AccountNote_fr { get; set; }
        public string AccountNote_tl { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
    
        public virtual Master_Bank Master_Bank { get; set; }
        public virtual Master_BankAccountType Master_BankAccountType { get; set; }
        public virtual Master_BankBranch Master_BankBranch { get; set; }
        public virtual Staff Staff { get; set; }
    }
}