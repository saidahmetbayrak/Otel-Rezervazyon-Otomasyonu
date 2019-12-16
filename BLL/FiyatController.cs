using Otel_Rezervasyon_Sistemi.DAL;
using Otel_Rezervasyon_Sistemi.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi.BLL
{
    public class FiyatController
    {
        FiyatManager fiyatManager = new FiyatManager();

        public List<Fiyat> FiyatlariGetir()
        {
            return fiyatManager.FiyatlariGetir();
        }

        public decimal FiyatGetirID(int id)
        {
            return fiyatManager.FiyatGetirID(id);
        }
        public bool FiyatGuncelle(int id,decimal fiyat)
        {
            return fiyatManager.FiyatGuncelle(id,fiyat);
        }
        public decimal FiyatOranGetir(int id)
        {
            return fiyatManager.FiyatOranGetir(id);
        }
    }
}
