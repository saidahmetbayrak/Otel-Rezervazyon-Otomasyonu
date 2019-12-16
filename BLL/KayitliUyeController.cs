using Otel_Rezervasyon_Sistemi.DAL;
using Otel_Rezervasyon_Sistemi.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi.BLL
{
    public class KayitliUyeController
    {
        KayitliUyeManager kayitliUyeManager = new KayitliUyeManager();

        public List<KayitliUye> KayitliUyeleriGetir()
        {
            List<KayitliUye> kayitliUyeler = kayitliUyeManager.kayitliUyeleriGetir();
            return kayitliUyeler;
        }

        public KayitliUye KayitliUyeleriGetirID(int id)
        {
            return kayitliUyeManager.KayitliUyeleriGetirID(id);
        }
       
        public bool KayitliUyeSil(int id)
        {
            return kayitliUyeManager.KayitliUyeSil(id);
        }
        public bool KayitliUyeGuncelle(KayitliUye kayitliUye)
        {
            return kayitliUyeManager.KayitliUyeGuncelle(kayitliUye);
        }
        public bool KayitliUyeEkle(KayitliUye kayitliUye)
        {
            return kayitliUyeManager.KayitliUyeEkle(kayitliUye);
        }
        public string KayitliUyeMail(string mail)
        {
            return kayitliUyeManager.KayitliUyeMail(mail);
        }
        public string KayitliUyeSifre(string sifre)
        {
            return kayitliUyeManager.KayitliUyeSifre(sifre);
        }

        public List<Rezervasyon> KayitliUyeAitGecmisRezervasyon(int kayitliUyeID)
        {
            return kayitliUyeManager.KayitliUyeAitGecmisRezervasyon(kayitliUyeID);
        }
    }
}
