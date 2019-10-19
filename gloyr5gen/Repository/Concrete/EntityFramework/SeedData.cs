using gloyr5gen.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gloyr5gen.Repository.Concrete.EntityFramework
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetRequiredService<GloyrContext>();

            context.Database.Migrate();

            if (!context.Advertisements.Any())
            {
                var advertisements = new[]
                {
                    new Advertisement(){ilanName="Yazılım Uzmanı", aciklama="Şirketimizin Tam Donanımlı Yazılım Ekibine Katılmaya Ne Dersiniz?", tecrube="en az 2 yıllık deneyim", egitimdurumu="Yazılım Mühendisi", firmasektoru="Yazılım Sektörü", calismasekli="Tam Zamanlı", pozisyonseviyesi="Orta Seviye Poziyon", ulke="Türkiye", sehir="İstanbul", acikadres="Yeşilköy Mahallesi", baslangicmaas=2300, bitismaas=3000, paylasimtarihi=DateTime.Now.AddDays(-6),  Image="1.jpg", HtmlContent="<b>Yazılım insanlık içindir.</b>",IsHome=true,IsApproved=true,IsFeatured=true },
         
                    new Advertisement(){ilanName="Web Programcısı", aciklama="Şirketimizin Tam Donanımlı Yazılım Ekibine Katılmaya Ne Dersiniz?", tecrube="en az 2 yıllık deneyim", egitimdurumu="Yazılım Mühendisi", firmasektoru="Yazılım Sektörü", calismasekli="Tam Zamanlı", pozisyonseviyesi="Orta Seviye Poziyon", ulke="Türkiye", sehir="İstanbul", acikadres="Yeşilköy Mahallesi", baslangicmaas=2300, bitismaas=3000, paylasimtarihi=DateTime.Now.AddDays(-9),  Image="1.jpg", HtmlContent="<b>Yazılım insanlık içindir.</b>",IsHome=true,IsApproved=true,IsFeatured=true },

                    new Advertisement(){ilanName="Grafiker", aciklama="Şirketimizin Tam Donanımlı Yazılım Ekibine Katılmaya Ne Dersiniz?", tecrube="en az 2 yıllık deneyim", egitimdurumu="Yazılım Mühendisi", firmasektoru="Yazılım Sektörü", calismasekli="Tam Zamanlı", pozisyonseviyesi="Orta Seviye Poziyon", ulke="Türkiye", sehir="İstanbul", acikadres="Yeşilköy Mahallesi", baslangicmaas=2300, bitismaas=3000, paylasimtarihi=DateTime.Now.AddDays(-32),  Image="1.jpg", HtmlContent="<b>Yazılım insanlık içindir.</b>",IsHome=true,IsApproved=true,IsFeatured=true },

                   new Advertisement(){ilanName="Muhasebeci", aciklama="Şirketimizin Tam Donanımlı Yazılım Ekibine Katılmaya Ne Dersiniz?", tecrube="en az 2 yıllık deneyim", egitimdurumu="Yazılım Mühendisi", firmasektoru="Yazılım Sektörü", calismasekli="Tam Zamanlı", pozisyonseviyesi="Orta Seviye Poziyon", ulke="Türkiye", sehir="İstanbul", acikadres="Yeşilköy Mahallesi", baslangicmaas=2300, bitismaas=3000, paylasimtarihi=DateTime.Now.AddDays(-12),  Image="1.jpg", HtmlContent="<b>Yazılım insanlık içindir.</b>",IsHome=true,IsApproved=true,IsFeatured=true },

                };
                context.Advertisements.AddRange(advertisements);

                var categories = new[]
                {
                     new Category(){CategoryName="Yazılım", Categoryaciklama="Şirketin En Önemli Departmanıdır.",IsHome=true,IsApproved=true,IsFeatured=true },

                     new Category(){CategoryName="Görsel Tasarım", Categoryaciklama="Şirketin En Önemli Departmanıdır.",IsHome=true,IsApproved=true,IsFeatured=true },

                     new Category(){CategoryName="Muhasebe", Categoryaciklama="Şirketin En Önemli Departmanıdır.",IsHome=true,IsApproved=true,IsFeatured=true },

                };
                context.Categories.AddRange(categories);

                var AdvertisementCategories = new[]
                {
                    new AdvertisementCategory(){Advertisement=advertisements[0], Category=categories[0]},
                    new AdvertisementCategory(){Advertisement=advertisements[1], Category=categories[0]},
                    new AdvertisementCategory(){Advertisement=advertisements[1], Category=categories[1]},
                    new AdvertisementCategory(){Advertisement=advertisements[2], Category=categories[1]},
                    new AdvertisementCategory(){Advertisement=advertisements[3], Category=categories[2]},

                };
                context.AddRange(AdvertisementCategories);

                var CalismaSeklis = new[]
                {
                    new CalismaSekli(){calismaseklibilgi="Tam Zamanlı", Advertisement=advertisements[0]},
                    new CalismaSekli(){calismaseklibilgi="Yarı Zamanlı", Advertisement=advertisements[1]},
                    new CalismaSekli(){calismaseklibilgi="Serbest Zamanlı", Advertisement=advertisements[2]}
                };
                context.AddRange(CalismaSeklis);


                var sehirs = new[]
                 {
                    new Sehir(){SehirName="İstanbul",Advertisement=advertisements[0]},
                    new Sehir(){SehirName="İzmir",Advertisement=advertisements[1]},
                    new Sehir(){SehirName="New York",Advertisement=advertisements[2]},
                };
                context.AddRange(sehirs);

                var ulkes = new[]
                {
                    new ulke(){ulkename="Türkiye"},
                    new ulke(){ulkename="Amerika"},
                    new ulke(){ulkename="İtalya"},
                };
                context.AddRange(ulkes);

                var ulkecategories = new[]
                {
                    new ulkecategory(){ulke=ulkes[0], Sehir=sehirs[0] },
                    new ulkecategory(){ulke=ulkes[0], Sehir=sehirs[1] },
                    new ulkecategory(){ulke=ulkes[1], Sehir=sehirs[2] },
                };
                context.AddRange(ulkecategories);
                context.SaveChanges();
            }
        }
    }
}
