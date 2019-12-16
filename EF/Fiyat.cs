using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi.EF
{
    [Table("Fiyat_Tablo")]
    public class Fiyat
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int FiyatID { get; set; }

        [Column("FiyatTipi", TypeName = "nvarchar", Order = 1)]
        [Required]
        public string fiyatTipi { get; set; }

        [Column("FiyatOran", TypeName = "money", Order = 2)]
        [Required]
        public decimal fiyatOran { get; set; }

    }
}
