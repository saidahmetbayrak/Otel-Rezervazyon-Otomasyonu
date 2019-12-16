using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otel_Rezervasyon_Sistemi.EF
{
    [Table("RezervasyonTipi_Tablo")]
    public class RezervasyonTipi
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RezervasyonTipiId { get; set; }

        [Column("Tipi", TypeName = "nvarchar", Order = 1)]
        [Required]
        [StringLength(30)]
        public string Tipi { get; set; }

        [Column("Acıklama", TypeName = "nvarchar", Order = 2)]
        [Required]
        [StringLength(100)]
        public string Aciklama { get; set; }

    }
}
