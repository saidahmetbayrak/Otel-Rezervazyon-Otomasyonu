using Otel_Rezervasyon_Sistemi.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi.DAL
{
    public class RezervasyonManager
    {
        OtelContext otelContext = new OtelContext();
        int etkilenenKayit;

        public List<Rezervasyon> RezervasyonlariGetir()
        {
            return otelContext.rezervasyonlar.ToList();
        }

        public Rezervasyon RezervasyonlariGetirID(int id)
        {
            return otelContext.rezervasyonlar.FirstOrDefault(x => x.RezervasyonID == id);
        }

        public bool RezervasyonSil(int id)
        {
            Rezervasyon silinecekRezervasyon = otelContext.rezervasyonlar.First(x => x.RezervasyonID == id);
            otelContext.rezervasyonlar.Remove(silinecekRezervasyon);
            etkilenenKayit = otelContext.SaveChanges();
            return etkilenenKayit > 0;
        }

        public bool RezervasyonGuncelle(Rezervasyon rezervasyon)
        {
            otelContext.rezervasyonlar.AddOrUpdate(rezervasyon);
            etkilenenKayit = otelContext.SaveChanges();
            return etkilenenKayit > 0;
        }

        public bool RezervasyonEkle(Rezervasyon rezervasyon)
        {
            var yeniRezervasyon = new Rezervasyon
            {
                RezervasyonID = rezervasyon.RezervasyonID,
                KayitliUyeID = rezervasyon.KayitliUyeID,
                RezervasyonTipiID = rezervasyon.RezervasyonTipiID,
                GirisTarihi = rezervasyon.GirisTarihi,
                CikisTarihi = rezervasyon.CikisTarihi,
                KisiSayisi = rezervasyon.KisiSayisi,
                OdaSayisi = rezervasyon.OdaSayisi,
                YatakSayisi = rezervasyon.YatakSayisi,
                OdaID = rezervasyon.OdaID,
                Fiyat = rezervasyon.Fiyat
            };
            otelContext.rezervasyonlar.Add(yeniRezervasyon);
            etkilenenKayit = otelContext.SaveChanges();
            return etkilenenKayit > 0;
        }

        public List<Rezervasyon> RezervasyonTipineGoreGetir(int rezervasyonTipi)
        {
            List<Rezervasyon> rezervasyonTipineGore = new List<Rezervasyon>();

            var rezervasyonTipineGoreRezervasyon = (from r in otelContext.rezervasyonlar join rt in otelContext.rezervasyonTipleri on r.RezervasyonTipiID equals rt.RezervasyonTipiId where rt.RezervasyonTipiId == rezervasyonTipi select new { r }).ToList();
            foreach (var item in rezervasyonTipineGoreRezervasyon)
            {
                rezervasyonTipineGore.Add(item.r);
            }
            return rezervasyonTipineGore;
        }

    }
}
