using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace Otel_Rezervasyon_Sistemi.EF
{
    [Table("Yonetici_Table")]
    public class Yoneticiler
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int YoneticiID { get; set; }


        [Column("Email", TypeName = "nvarchar", Order = 1)]
        [Required][MaxLength(100)]
        public string Email { get; set; }

  

        [Column("Sifre", TypeName = "nvarchar", Order = 2)]
        [Required]
        [RegularExpression("^[a-zA-Z0-9]*$")]
        [MinLength(8)]
        [MaxLength(16)]
        public string Sifre { get; set; }

    }
}
