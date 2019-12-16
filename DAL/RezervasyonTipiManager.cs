using Otel_Rezervasyon_Sistemi.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi.DAL
{
    public class RezervasyonTipiManager
    {
        OtelContext otelContext = new OtelContext();
        int etkilenenKayit;


        public List<RezervasyonTipi> rezervasyonTipleriniGetir()
        {
            return otelContext.rezervasyonTipleri.ToList();
        }


        public string RezervasyonTipleriniGetirID(int id)
        {
            string tip = string.Empty;

            var tipGetir = (from rt in otelContext.rezervasyonTipleri where rt.RezervasyonTipiId == id select new { rt.Tipi }).ToList();

            foreach (var item in tipGetir)
            {
                tip = item.Tipi;
            }

            return tip;
        }

        public bool RezervasyonTipiSil(int id)
        {
            RezervasyonTipi silinecekRezervasyonTipi = otelContext.rezervasyonTipleri.First(x => x.RezervasyonTipiId == id);
            otelContext.rezervasyonTipleri.Remove(silinecekRezervasyonTipi);
            etkilenenKayit = otelContext.SaveChanges();
            return etkilenenKayit > 0;
        }


        public bool RezervasyonTipiGuncelle(RezervasyonTipi rezervasyonTipi)
        {
            otelContext.rezervasyonTipleri.AddOrUpdate(rezervasyonTipi);
            etkilenenKayit = otelContext.SaveChanges();
            return etkilenenKayit > 0;
        }


        public bool RezervasyonTipiEkle(RezervasyonTipi rezervasyonTipi)
        {
            var yeniRezervasyonTipi = new RezervasyonTipi { RezervasyonTipiId = rezervasyonTipi.RezervasyonTipiId, Tipi = rezervasyonTipi.Tipi, Aciklama = rezervasyonTipi.Aciklama };
            otelContext.rezervasyonTipleri.Add(yeniRezervasyonTipi);
            etkilenenKayit = otelContext.SaveChanges();
            return etkilenenKayit > 0;
        }

        public string RezervasyonTipiAcıklamaGetir(int id)
        {
            string aciklama = string.Empty;

            var aciklamaGetir = (from rt in otelContext.rezervasyonTipleri where rt.RezervasyonTipiId == id select new { rt.Aciklama }).ToList();

            foreach (var item in aciklamaGetir)
            {
                 aciklama =  item.Aciklama;
            }

            return aciklama;
        }


    }
}
