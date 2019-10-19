using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gloyr5gen.Entity
{
    public class Advertisement
    {
        public int AdvertisementId { get; set; }
        public string ilanName { get; set; } //
        public string aciklama { get; set; } //
        public string tecrube { get; set; } //
        public string egitimdurumu { get; set; } //
        public string firmasektoru { get; set; } //
        public string calismasekli { get; set; } //
        public string pozisyonseviyesi { get; set; } //
        public string ulke { get; set; } //
        public string sehir { get; set; }//
        public string acikadres { get; set; }//
        public double baslangicmaas { get; set; } //
        public double bitismaas { get; set; } //
        public DateTime paylasimtarihi { get; set; }
        public  string Image { get; set; }
        public string HtmlContent { get; set; }

        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public bool IsFeatured { get; set; }
        public List<AdvertisementCategory> AdvertisementCategories { get; set; }
        public List<Sehir> Sehirs  { get; set; }
        public List<CalismaSekli> CalismaSeklis { get; set; }
    }
}
//ıd
//is adı
//gereksinimler
//-tecrübe
//-eğitim seviyesi
//-firma sektörü
//-çalışma şekli
//-pozisyon seviyesi
//-personel sayısı
//-ülke/şehir