using Otel_Rezervasyon_Sistemi.EF;
using System.Collections.Generic;
using System.Linq;

namespace Otel_Rezervasyon_Sistemi.DAL
{
    public class FiyatManager
    {
        OtelContext otelContext = new OtelContext();

        public List<Fiyat> FiyatlariGetir()
        {
            return otelContext.fiyatlar.ToList();
        }

        public decimal FiyatGetirID(int id)
        {
            decimal _fiyat = 0;
            var fiyatGetir = (from f in otelContext.fiyatlar where f.FiyatID == id select new { f.fiyatOran }).ToList();
            foreach (var item in fiyatGetir)
            {
                _fiyat = item.fiyatOran;
            }
            return _fiyat;
        }

        public bool FiyatGuncelle(int id,decimal fiyat)
        {

            var fiyatGuncelle = (from f in otelContext.fiyatlar where f.FiyatID == id select f);
            foreach (var item in fiyatGuncelle)
            {
                item.fiyatOran = fiyat;
            }
            
            int etkilenenKayit = otelContext.SaveChanges();
            return etkilenenKayit > 0;
        }
        public decimal FiyatOranGetir(int id)
        {
            decimal fiyatOran = 0;

            var fiyatGetir = (from f in otelContext.fiyatlar where f.FiyatID == id select new { f.fiyatOran }).ToList();

            foreach (var item in fiyatGetir)
            {
                fiyatOran = item.fiyatOran;
            }
            return fiyatOran;
        }
    }
}
