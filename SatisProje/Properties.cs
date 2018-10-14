using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisProje
{
    class urunlist
    {
        public string UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        public string Kategori { get; set; }
        public string Uyari_limiti { get; set; }
        public string Birim_tipi { get; set; }
        public string Kayit_durumu { get; set; }
        public int Id { get; set; }
    }
    class iliskilist
    {
        public string Kodu { get; set; }
        public string Yetkili_kisi { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Kayit_durumu { get; set; }
        public string Adres { get; set; }
        public int Id { get; set; }
    }
    class urunallist: siparislist
    {   
        public string Tedarikci_adi { get; set; }
        
    }

    class urunsatlist: siparislist
    {      
        public string Musteri_adi { get; set; }      
    }
    abstract class siparislist
    {
        public string Kategori { get; set; }
        public string Urun_adi { get; set; }
        public string Birim_tipi { get; set; }
        public string Birim_alt_tipi { get; set; }
        public int Miktar { get; set; }
        public decimal Birim_fiyat { get; set; }
        public decimal Toplam_fiyat { get; set; }
        public decimal Pesin_odenen { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }



    }
    class Kategorilist
    {
       
        public string Kategori { get; set; }
        public string Kayit_durumu { get; set; }
        public int Id { get; set; }
    }

    class Birimtipilist
    {
       
        public string Birim_tipi { get; set; }
        public string Kayit_durumu { get; set; }
        public int Id { get; set; }
    }

    class Birimalttipilist
    {
       
        public string Birim_alt_tipi { get; set; }
        public string Kayit_durumu { get; set; }
        public int Id { get; set; }
    }
}
