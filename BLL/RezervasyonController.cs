using Otel_Rezervasyon_Sistemi.DAL;
using Otel_Rezervasyon_Sistemi.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi.BLL
{
    public class RezervasyonController
    {
        RezervasyonManager rezervasyonManager = new RezervasyonManager();
        public List<Rezervasyon> RezervasyonlariGetir()
        {
            List<Rezervasyon> rezervasyons = rezervasyonManager.RezervasyonlariGetir();
            return rezervasyons;
        }
        public Rezervasyon RezervasyonlariGetirID(int id)
        {
            return rezervasyonManager.RezervasyonlariGetirID(id);
        }
        
        public bool RezervasyonlariSil(int id)
        {
            return rezervasyonManager.RezervasyonSil(id);
        }
        public bool RezervasyonlariGuncelle(Rezervasyon rezervasyon)
        {
            return rezervasyonManager.RezervasyonGuncelle(rezervasyon);
        }
        public bool RezervasyonEkle(Rezervasyon rezervasyon)
        {
            return rezervasyonManager.RezervasyonEkle(rezervasyon);
        }
        public List<Rezervasyon> RezervasyonTipineGoreGetir(int rezervasyonTipi)
        {
            return rezervasyonManager.RezervasyonTipineGoreGetir(rezervasyonTipi);
        }
    }
}
