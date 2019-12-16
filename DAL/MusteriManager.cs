using Otel_Rezervasyon_Sistemi.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi.DAL
{
    public class MusteriManager
    {
        OtelContext otelContext = new OtelContext();
        int etkilenenKayit;
        public List<Musteri> MusterileriGetir()
        {
            return otelContext.musteriler.ToList();
        }
        public Musteri MusterileriGetirID(int id)
        {
            return otelContext.musteriler.FirstOrDefault(x => x.MusteriId == id);
        }
        
        

        public bool MusteriSil(int id)
        {
            Musteri silinecekMusteri = otelContext.musteriler.First(x => x.MusteriId == id);
            otelContext.musteriler.Remove(silinecekMusteri);
            etkilenenKayit = otelContext.SaveChanges();
            return etkilenenKayit > 0;
        }
        public bool MusteriGuncelle(Musteri musteri)
        {
            otelContext.musteriler.AddOrUpdate(musteri);
            etkilenenKayit = otelContext.SaveChanges();
            return etkilenenKayit > 0;
        }
        public bool MusteriEkle(Musteri musteri)
        {
            var yeniMusteri = new Musteri
            {
                MusteriId = musteri.MusteriId,
                OdaId = musteri.OdaId,
                TcNO = musteri.TcNO,
                Ad = musteri.Ad,
                Soyad = musteri.Soyad
            };
            otelContext.musteriler.Add(yeniMusteri);
            etkilenenKayit = otelContext.SaveChanges();
            return etkilenenKayit > 0;
        }
    }
}
