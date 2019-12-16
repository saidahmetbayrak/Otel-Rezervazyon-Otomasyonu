using Otel_Rezervasyon_Sistemi.DAL;
using Otel_Rezervasyon_Sistemi.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi.BLL
{
    public class MusteriController
    {
        MusteriManager musteriManager = new MusteriManager();

        public List<Musteri> MusterileriGetir()
        {
            List<Musteri> musteris = musteriManager.MusterileriGetir();
            return musteris;
        }
        public Musteri MusteriGetirID(int id)
        {
            return musteriManager.MusterileriGetirID(id);
        }
       
        public bool MusteriSil(int id)
        {
            return musteriManager.MusteriSil(id);
        }
        public bool MusteriGuncelle(Musteri musteri)
        {
            return musteriManager.MusteriGuncelle(musteri);
        }
        public bool MusteriEkle(Musteri musteri)
        {
            return musteriManager.MusteriEkle(musteri);
        }


    }
}
