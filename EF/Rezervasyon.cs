
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otel_Rezervasyon_Sistemi.EF
{
    [Table("Rezervasyon_Tablo")]
    public class Rezervasyon
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int RezervasyonID { get; set; }

        [ForeignKey("KayitliUye")]
        [Required]
        [Column("KayitliUyeID", TypeName = "int", Order = 1)]
        public int KayitliUyeID { get; set; }

        public KayitliUye KayitliUye { get; set; }

        [ForeignKey("RezervasyonTipi")]
        [Column("RezervasyonTipiID", TypeName = "int", Order = 2)]
        public int RezervasyonTipiID { get; set; }

        public RezervasyonTipi RezervasyonTipi { get; set; }

        [Column("GirisTarihi", TypeName = "date", Order = 3)]
        [Required]
        public DateTime GirisTarihi { get; set; }

        [Column("CikisTarihi", TypeName = "date", Order = 4)]
        [Required]
        public DateTime CikisTarihi { get; set; }

        [Column("KisiSayisi", TypeName = "int", Order = 5)]
        [Required]
        public int KisiSayisi { get; set; }
        [Column("OdaSayisi", TypeName = "int", Order = 6)]
        [Required]
        public int OdaSayisi { get; set; }
        [Column("YatakSayisi", TypeName = "int", Order = 7)]
        [Required]
        public int YatakSayisi { get; set; }

        [ForeignKey("Oda")]
        [Column("OdaID", TypeName = "int", Order = 9)]
        public int OdaID { get; set; }

        public Oda Oda { get; set; }

        [Column("Fiyat", TypeName = "money", Order = 8)]
        [Required]
        public decimal Fiyat { get; set; }
    }
}
