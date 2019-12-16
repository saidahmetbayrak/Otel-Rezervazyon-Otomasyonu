using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace Otel_Rezervasyon_Sistemi.EF
{
    [Table("KayitliUye_Tablo")]
    public class KayitliUye
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order =0)]
        public int KayitliUyeID { get; set; }

        [Column("Mail", TypeName = "nvarchar", Order = 1)]
        [Required]
        [MaxLength(100)]
        public string Mail { get; set; }
                                           
        [Column("Sifre", TypeName = "nvarchar", Order = 2)]
        [Required][MaxLength(16)][MinLength(8)]
        public string Sifre { get; set; }

    }
}
