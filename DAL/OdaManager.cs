using Otel_Rezervasyon_Sistemi.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Otel_Rezervasyon_Sistemi.DAL
{
    public class OdaManager
    {

        OtelContext otelContext = new OtelContext();
        int etkilenenKayit;
       

        public List<Oda> OdalariGetir()
        {
            return otelContext.Odalar.ToList();
        }

        public Oda OdaGetirID(int id)
        {
            return otelContext.Odalar.FirstOrDefault(x => x.OdaID == id);
        }

        public bool OdaSil(int id)
        {
            Oda silinecekOda = otelContext.Odalar.First(x => x.OdaID == id);
            otelContext.Odalar.Remove(silinecekOda);
            etkilenenKayit = otelContext.SaveChanges();
            return etkilenenKayit > 0;
        }
        

        public bool OdaGuncelle(Oda oda)
        {
            otelContext.Odalar.AddOrUpdate(oda);
            etkilenenKayit = otelContext.SaveChanges();
            return etkilenenKayit > 0;
        }

        public bool OdaEkle(Oda oda)
        {
            var yeniOda = new Oda { OdaID = oda.OdaID, OdaNumarasi = oda.OdaNumarasi, KisiSayisi = oda.KisiSayisi, DoluMu = oda.DoluMu };
            otelContext.Odalar.Add(yeniOda);
            etkilenenKayit = otelContext.SaveChanges();
            return etkilenenKayit > 0;
        }

        public List<string> TarihAralıgınaGoreDoluOdalar(DateTime girisTarihi,DateTime cikisTarihi)
        {
            List<string> _odaDurum = new List<string>();

            var odaDurumu = (from r in otelContext.rezervasyonlar join o in otelContext.Odalar on r.OdaID equals o.OdaID where r.GirisTarihi >= girisTarihi.Date &&  r.GirisTarihi < cikisTarihi.Date && o.DoluMu==true select new {o.OdaNumarasi}).ToList();

            foreach (var item in odaDurumu)
            {
                _odaDurum.Add(item.OdaNumarasi);
            }

            return _odaDurum;
        }
        public List<string> TarihAralıgınaGoreBosOdalar(DateTime girisTarihi, DateTime cikisTarihi)
        {
            List<string> _odaDurum = new List<string>();

            var odaDurumu = (otelContext.Odalar.Where(x => !otelContext.rezervasyonlar.Any(y => y.OdaID == x.OdaID && y.GirisTarihi >= girisTarihi.Date && y.GirisTarihi < cikisTarihi.Date))).ToList();
            foreach (var item in odaDurumu)
            {
                _odaDurum.Add(item.OdaNumarasi);

            }
            
            return _odaDurum;
        }

        public List<string> TarihAralıgınaGoreDoluOdalardaKalacakMusteriler(DateTime girisTarihi,DateTime cikisTarihi)
        {
            List<string> doluMusteriler = new List<string>();

            var doluOdaMusteriler = otelContext.musteriler.Join(otelContext.Odalar, m => m.OdaId, o => o.OdaID, (m, o) => 
            new { m, o }).Join(otelContext.rezervasyonlar, mo => mo.o.OdaID, r => r.OdaID, (mo, r) => 
            new { mo, r }).Where(m => otelContext.Odalar.Any(o => o.OdaID == m.r.OdaID && o.DoluMu == true && m.r.GirisTarihi >= girisTarihi.Date && m.r.GirisTarihi < cikisTarihi.Date)).Select(m => 
            new { m.mo.m.Ad, m.mo.m.Soyad, m.mo.m.TcNO, m.mo.o.OdaNumarasi }).ToList();

            var doluOdaGetir = (otelContext.musteriler.Where(x => !otelContext.Odalar.Any(y => y.OdaID == x.OdaId && y.DoluMu == true))).ToList();

            foreach (var item in doluOdaMusteriler)
            {
                doluMusteriler.Add(item.Ad + " " + item.Soyad + " / " + item.TcNO + " / " + item.OdaNumarasi);
            }
            return doluMusteriler;
        }
        public void OdaSil()
        {
            var silOda = from o in otelContext.Odalar select o;

            foreach (var item in silOda)
            {
                otelContext.Odalar.Remove(item);
            }
            otelContext.SaveChanges();
        }
        public string OdaNumarasi (int id)
        {
            string _odaNumarasi = string.Empty;
            var odaNumarasi = (from o in otelContext.Odalar where o.OdaID == id select new { o.OdaNumarasi }).ToList();
           
            foreach (var item in odaNumarasi)
            {
                _odaNumarasi = item.OdaNumarasi;
            }
            return _odaNumarasi;
        }
        
        public int OdaIDGetir()
        {
            int _odaID = 0;
            var odaIDGetir = (from o in otelContext.Odalar select new {o.OdaID}).ToList();
            foreach (var item in odaIDGetir)
            {
                _odaID = item.OdaID;
            }
            return _odaID;
        }
        
        public void OdaDurumDolu(int id)
        {
            Oda odaDurum = (from o in otelContext.Odalar where o.OdaID == id select o).SingleOrDefault();
            odaDurum.DoluMu = true;
            otelContext.SaveChanges();
        }
        public void OdaDurumBos()
        {
            var odaDurum = (from o in otelContext.Odalar select o).ToList();
            foreach (var item in odaDurum)
            {
                item.DoluMu = false;
            }
            otelContext.SaveChanges();
        }
        public void OdaDurumBos(int id)
        {
            var odaDurum = (from o in otelContext.Odalar where o.OdaID==id  select o).ToList();
            foreach (var item in odaDurum)
            {
                item.DoluMu = false;
            }
            otelContext.SaveChanges();
        }
        public bool OdaDurum(int id)
        {
            bool _odaDurum = false;
            var odaDurumGetir = (from o in otelContext.Odalar where o.OdaID == id select new { o.DoluMu }).ToList();
            foreach (var item in odaDurumGetir)
            {
                _odaDurum = item.DoluMu;
            }
            return _odaDurum;
        }

        public DateTime CikisTarihleriniGetir()
        {
            DateTime _cikisTarihleri = DateTime.Now ;

            var cikisTarihleriniGetir = (from o in otelContext.Odalar join r in otelContext.rezervasyonlar on o.OdaID equals r.OdaID select new { r.CikisTarihi }).ToList();
            foreach (var item in cikisTarihleriniGetir)
            {
                _cikisTarihleri = item.CikisTarihi;
            }

            return _cikisTarihleri;
        }
        public List<Oda> BosOdalariGetir()
        {
            List<Oda> _bosOdalar = new List<Oda>();
            var bosOda = (from o in otelContext.Odalar where o.DoluMu == false select o).ToList();
            foreach (var item in bosOda)
            {
                _bosOdalar.Add(item);
            }
            return _bosOdalar;
        }
    }
    

}
