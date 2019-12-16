using Otel_Rezervasyon_Sistemi.DAL;
using Otel_Rezervasyon_Sistemi.EF;
using System;
using System.Collections.Generic;

namespace Otel_Rezervasyon_Sistemi.BLL
{
    public class OdaController
    {
        OdaManager odaManager = new OdaManager();

       
        public List<Oda> OdalariGetir()
        {
            List<Oda> odas = odaManager.OdalariGetir();
            return odas;
        }
        public Oda OdalariiGetirID(int id)
        {
            return odaManager.OdaGetirID(id);
        }
        public void OdaDurumBos(int id)
        {
            odaManager.OdaDurumBos(id);
        }
        public bool OdaSil(int id)
        {
            return odaManager.OdaSil(id);
        }

        public bool OdaGuncelle(Oda oda)
        {
            return odaManager.OdaGuncelle(oda);
        }

        public bool OdaEkle(Oda oda)
        {
            return odaManager.OdaEkle(oda);
        }

        public List<string> TarihAralıgınaGoreDoluOdalar(DateTime girisTarihi, DateTime cikisTarihi)
        {
           return odaManager.TarihAralıgınaGoreDoluOdalar(girisTarihi, cikisTarihi);
        }
        public List<string> TarihAralıgınaGoreBosOdalar(DateTime girisTarihi, DateTime cikisTarihi)
        {
            return odaManager.TarihAralıgınaGoreBosOdalar(girisTarihi, cikisTarihi);
        }
        public List<string> TarihAralıgınaGoreDoluOdalardaKalacakMusteriler(DateTime girisTarihi, DateTime cikisTarihi)
        {
            return odaManager.TarihAralıgınaGoreDoluOdalardaKalacakMusteriler(girisTarihi,cikisTarihi);
        }
        public string OdaNumarasi(int id)
        {
            return odaManager.OdaNumarasi(id);
        }

        public void OdaSil()
        {
            odaManager.OdaSil();
        }
        public int OdaIDGetir()
        {
            return odaManager.OdaIDGetir();
        }
        public void OdaDurumGuncelle(int id)
        {
            odaManager.OdaDurumDolu(id);
        }
        public void OdaDurumBos()
        {
            odaManager.OdaDurumBos();
        }
        public bool OdaDurum(int id)
        {
            return odaManager.OdaDurum(id);
        }
        public DateTime CikisTarihleriniGetir()
        {
            return odaManager.CikisTarihleriniGetir();
        }
        public List<Oda> BosOdalariGetir()
        {
            return odaManager.BosOdalariGetir();
        }
    }
}
