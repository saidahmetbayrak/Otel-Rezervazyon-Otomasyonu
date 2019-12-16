using Otel_Rezervasyon_Sistemi.DAL;
using Otel_Rezervasyon_Sistemi.EF;
using System.Collections.Generic;

namespace Otel_Rezervasyon_Sistemi.BLL
{
    public class RezervasyonTipiController
    {
        RezervasyonTipiManager rezervasyonTipiManager = new RezervasyonTipiManager();

        public List<RezervasyonTipi> RezervasyonTipleriniGetir()
        {
            List<RezervasyonTipi> rezervasyonTipleri = rezervasyonTipiManager.rezervasyonTipleriniGetir();
            return rezervasyonTipleri;
        }

        public string RezervasyonTipleriniGetirID(int id)
        {
            return rezervasyonTipiManager.RezervasyonTipleriniGetirID(id);
        }


        public bool RezervasyonTipiSil(int id)
        {
            return rezervasyonTipiManager.RezervasyonTipiSil(id);
        }

        public bool RezervasyonTipiGuncelle(RezervasyonTipi rezervasyonTipi)
        {
            return rezervasyonTipiManager.RezervasyonTipiGuncelle(rezervasyonTipi);
        }

        public bool RezervasyonTipiEkle(RezervasyonTipi rezervasyonTipi)
        {
            return rezervasyonTipiManager.RezervasyonTipiEkle(rezervasyonTipi);
        }

        public string RezervasyonTipiAcıklamaGetir(int id)
        {
            return rezervasyonTipiManager.RezervasyonTipiAcıklamaGetir(id);
        }
    }
}
