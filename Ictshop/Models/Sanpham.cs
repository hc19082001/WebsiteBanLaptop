//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ictshop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sanpham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sanpham()
        {
            this.Chitietdonhangs = new HashSet<Chitietdonhang>();
        }
    
        public int Masp { get; set; }
        public string Tensp { get; set; }
        public Nullable<decimal> Giatien { get; set; }
        public Nullable<int> Soluong { get; set; }
        public string Mota { get; set; }
        public Nullable<int> Bonhotrong { get; set; }
        public Nullable<bool> Sanphammoi { get; set; }
        public Nullable<int> Ram { get; set; }
        public string Anhbia { get; set; }
        public Nullable<int> Mahang { get; set; }
        public Nullable<int> Mahdh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietdonhang> Chitietdonhangs { get; set; }
        public virtual Hangsanxuat Hangsanxuat { get; set; }
        public virtual Hedieuhanh Hedieuhanh { get; set; }
    }
}
