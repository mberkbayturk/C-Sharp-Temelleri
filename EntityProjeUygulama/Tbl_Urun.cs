//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityProjeUygulama
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Urun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Urun()
        {
            this.Tbl_Satıs = new HashSet<Tbl_Satıs>();
        }
    
        public int UrunId { get; set; }
        public string UrunAdı { get; set; }
        public string Marka { get; set; }
        public Nullable<short> Stok { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public Nullable<bool> Durum { get; set; }
        public Nullable<int> Kategori { get; set; }
    
        public virtual Tbl_Kategori Tbl_Kategori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Satıs> Tbl_Satıs { get; set; }
    }
}
