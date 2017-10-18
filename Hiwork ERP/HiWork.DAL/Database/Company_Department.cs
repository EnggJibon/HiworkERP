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
    
    public partial class Company_Department
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> CompanyID { get; set; }
        public Nullable<System.Guid> DepartmentID { get; set; }
        public Nullable<long> LocationID { get; set; }
        public Nullable<int> TradingOfficeID { get; set; }
        public string Name_Local { get; set; }
        public string Name_Global { get; set; }
        public string PhoneNo { get; set; }
        public string Fax { get; set; }
        public string PostalCode { get; set; }
        public string Address_en { get; set; }
        public string Address_jp { get; set; }
        public string Address_kr { get; set; }
        public string Address_cn { get; set; }
        public string Address_fr { get; set; }
        public string Address_tl { get; set; }
        public string BillingClientName_en { get; set; }
        public string BillingClientName_jp { get; set; }
        public string BillingClientName_kr { get; set; }
        public string BillingClientName_cn { get; set; }
        public string BillingClientName_fr { get; set; }
        public string BillingClientName_tl { get; set; }
        public string BillingTo { get; set; }
        public string BillingEmail { get; set; }
        public string BillingAddress_en { get; set; }
        public string BillingAddress_jp { get; set; }
        public string BillingAddress_kr { get; set; }
        public string BillingAddress_cn { get; set; }
        public string BillingAddress_fr { get; set; }
        public string BillingAddress_tl { get; set; }
        public string BillingContactNo { get; set; }
        public string BillingFax { get; set; }
        public string BillingPaymentTerms { get; set; }
        public Nullable<int> InchargeClientTypeID { get; set; }
        public Nullable<long> InchargeTradingOfficeID { get; set; }
        public string InchargeName_Local { get; set; }
        public string InchargeName_pronounciation { get; set; }
        public string InchargeName_Global { get; set; }
        public string InchargePhoneNo { get; set; }
        public string InchargeCellPhoneNo { get; set; }
        public string InchargeEmail { get; set; }
        public string InchargePromotionEmail { get; set; }
        public string InchargeEmail_CC { get; set; }
        public string InchargePassword { get; set; }
        public Nullable<System.DateTime> InchargeSalesPlanDate { get; set; }
        public string InchargeInternalName { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<long> ApplicationId { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Master_Department Master_Department { get; set; }
    }
}
