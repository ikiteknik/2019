//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBitirmeProjesi.DbEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class KISILER
    {
        public int KisiKey { get; set; }
        public byte YetkiTip { get; set; }
        public string KisiAdi { get; set; }
        public string KisiSoyadi { get; set; }
        public bool AktifMi { get; set; }
        public string EPosta { get; set; }
        public string Sifre { get; set; }
        public string TcNo { get; set; }
        public Nullable<System.DateTime> IseGirisTarihi { get; set; }
        public Nullable<System.DateTime> SonTarih { get; set; }
        public Nullable<int> KalanGun { get; set; }
        public string ResimPath { get; set; }
    }
}
