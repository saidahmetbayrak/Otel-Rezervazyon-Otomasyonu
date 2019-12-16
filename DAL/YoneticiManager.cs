using Otel_Rezervasyon_Sistemi.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi.DAL
{
  public  class YoneticiManager
    {
        OtelContext otelContext = new OtelContext();
        int etkilenenKayit;

        public List<Yoneticiler> yoneticileriGetir()
        {
            return otelContext.yoneticiler.ToList();
        }

        public Yoneticiler YoneticileriGetirID(int id)
        {
            return otelContext.yoneticiler.FirstOrDefault(x => x.YoneticiID == id);
        }

        

        public bool YoneticiSil(int id)
        {
            Yoneticiler silinecekYonetici = otelContext.yoneticiler.First(x => x.YoneticiID == id);
            otelContext.yoneticiler.Remove(silinecekYonetici);
            etkilenenKayit = otelContext.SaveChanges();
            return etkilenenKayit > 0;
        }

        public bool YoneticiGuncelle(Yoneticiler yonetici)
        {
            otelContext.yoneticiler.AddOrUpdate(yonetici);
            etkilenenKayit = otelContext.SaveChanges();
            return etkilenenKayit > 0;
        }

        public bool YoneticiEkle(Yoneticiler yonetici)
        {
            var yeniYonetici = new Yoneticiler { YoneticiID = yonetici.YoneticiID, Email = yonetici.Email, Sifre = yonetici.Sifre };
            otelContext.yoneticiler.Add(yeniYonetici);
            etkilenenKayit = otelContext.SaveChanges();
            return etkilenenKayit > 0;
        }
    }
}
