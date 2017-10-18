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
    
    public partial class Master_Currency
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Master_Currency()
        {
            this.CompanyRFMAnalysis = new HashSet<CompanyRFMAnalysi>();
            this.CompanyRFMAnalysis1 = new HashSet<CompanyRFMAnalysi>();
            this.CompanyRFMAnalysis2 = new HashSet<CompanyRFMAnalysi>();
            this.CompanyRFMAnalysis3 = new HashSet<CompanyRFMAnalysi>();
            this.Estimations = new HashSet<Estimation>();
            this.HiworkLanguagePrices = new HashSet<HiworkLanguagePrice>();
            this.Master_Bank = new HashSet<Master_Bank>();
            this.Master_Country = new HashSet<Master_Country>();
            this.Master_CurrencyRate = new HashSet<Master_CurrencyRate>();
            this.Master_UnitPriceSetting = new HashSet<Master_UnitPriceSetting>();
            this.Order_Web = new HashSet<Order_Web>();
            this.TranslationLevels = new HashSet<TranslationLevel>();
            this.TransproLanguagePriceCategories = new HashSet<TransproLanguagePriceCategory>();
        }
    
        public long ID { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
        public string Name_en { get; set; }
        public string Name_jp { get; set; }
        public string Name_kr { get; set; }
        public string Name_cn { get; set; }
        public string Name_fr { get; set; }
        public string Name_tl { get; set; }
        public bool IsDefalut { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyRFMAnalysi> CompanyRFMAnalysis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyRFMAnalysi> CompanyRFMAnalysis1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyRFMAnalysi> CompanyRFMAnalysis2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyRFMAnalysi> CompanyRFMAnalysis3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estimation> Estimations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HiworkLanguagePrice> HiworkLanguagePrices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Master_Bank> Master_Bank { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Master_Country> Master_Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Master_CurrencyRate> Master_CurrencyRate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Master_UnitPriceSetting> Master_UnitPriceSetting { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Web> Order_Web { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TranslationLevel> TranslationLevels { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransproLanguagePriceCategory> TransproLanguagePriceCategories { get; set; }
    }
}
