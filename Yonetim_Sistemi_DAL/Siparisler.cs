//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yonetim_Sistemi_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Siparisler
    {
        public int SiparisID { get; set; }
        public Nullable<int> MusteriID { get; set; }
        public Nullable<int> UrunID { get; set; }
        public Nullable<int> TedarikciID { get; set; }
        public Nullable<int> Miktar { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    
        public virtual Musteriler Musteriler { get; set; }
        public virtual Tedarikci Tedarikci { get; set; }
        public virtual Urunler Urunler { get; set; }
    }
}
