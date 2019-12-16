using Otel_Rezervasyon_Sistemi.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi.DAL
{
   public class KayitliUyeManager
    {
        OtelContext otelContext = new OtelContext();
        int etkilenenKayit;
        public List<KayitliUye> kayitliUyeleriGetir ()
        {
            return otelContext.kayitliUyeler.ToList();
        }

        public KayitliUye KayitliUyeleriGetirID(int id)
        {
            return otelContext.kayitliUyeler.FirstOrDefault(x => x.KayitliUyeID==id);
        }

        public bool KayitliUyeSil(int id)
        {
            KayitliUye silinecekUye = otelContext.kayitliUyeler.First(x => x.KayitliUyeID == id);
           otelContext.kayitliUyeler.Remove(silinecekUye);
            etkilenenKayit = otelContext.SaveChanges();
            return etkilenenKayit > 0;
        }

        public bool KayitliUyeGuncelle(KayitliUye kayitliUye)
        {
            otelContext.kayitliUyeler.AddOrUpdate(kayitliUye);
            etkilenenKayit = otelContext.SaveChanges();
            return etkilenenKayit > 0;
        }

        public bool KayitliUyeEkle(KayitliUye kayitliUye)
        {
            var yeniKayitliUye=new KayitliUye{KayitliUyeID = kayitliUye.KayitliUyeID,Mail=kayitliUye.Mail,Sifre=kayitliUye.Sifre };
            otelContext.kayitliUyeler.Add(yeniKayitliUye);
            etkilenenKayit = otelContext.SaveChanges();
            return etkilenenKayit > 0;
        }

        public string KayitliUyeMail(string mail)
        {
            string kayitliUyeMail=string.Empty;
            var kayitliUyeMailGetir = (from k in otelContext.kayitliUyeler where k.Mail == mail select new { k.Mail });

            foreach (var item in kayitliUyeMailGetir)
            {
                kayitliUyeMail = item.Mail;
            }

            return kayitliUyeMail;
        }
        public string KayitliUyeSifre(string sifre)
        {
            string kayitliUyeSifre = string.Empty;
            var kayitliUyesifreGetir = (from k in otelContext.kayitliUyeler where k.Sifre == sifre select new { k.Sifre });
            foreach (var item in kayitliUyesifreGetir)
            {
                kayitliUyeSifre = item.Sifre;
            }
            return kayitliUyeSifre;
        }

        public List<Rezervasyon> KayitliUyeAitGecmisRezervasyon(int kayitliUyeID)
        {
            List<Rezervasyon> kayitliUyeGecmisRezervasyonListe = new List<Rezervasyon>();

            var kayitliUyeGecmisRezervasyon = (from k in otelContext.kayitliUyeler join r in otelContext.rezervasyonlar on k.KayitliUyeID equals r.KayitliUyeID where k.KayitliUyeID == kayitliUyeID select new { r }).ToList();
            foreach (var item in kayitliUyeGecmisRezervasyon)
            {
                kayitliUyeGecmisRezervasyonListe.Add(item.r);
            }
            return kayitliUyeGecmisRezervasyonListe;
        }

      
    }
}
