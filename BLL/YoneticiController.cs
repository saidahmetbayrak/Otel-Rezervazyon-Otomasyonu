using Otel_Rezervasyon_Sistemi.DAL;
using Otel_Rezervasyon_Sistemi.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi.BLL
{
    public class YoneticiController
    {
        YoneticiManager yoneticiManager = new YoneticiManager();

        public List<Yoneticiler> YoneticileriGetir()
        {
            List<Yoneticiler> yoneticiler = yoneticiManager.yoneticileriGetir();
            return yoneticiler;
        }

        public Yoneticiler YoneticileriGetirID(int id)
        {
            return yoneticiManager.YoneticileriGetirID(id);
        }

       

        public bool YoneticiSil(int id)
        {
            return yoneticiManager.YoneticiSil(id);
        }

        public bool YoneticiGuncelle(Yoneticiler yonetici)
        {
            return yoneticiManager.YoneticiGuncelle(yonetici);
        }

        public bool YoneticiEkle(Yoneticiler yonetici)
        {
            return yoneticiManager.YoneticiEkle(yonetici);
        }
    }
}
