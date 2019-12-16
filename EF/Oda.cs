using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otel_Rezervasyon_Sistemi.EF
{
    [Table("Oda_Tablo")]
    public class Oda
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int OdaID { get; set; }

        [Column("OdaNumarasi", TypeName = "nvarchar", Order = 1)]
        [DefaultValue(0)]
        public string OdaNumarasi { get; set; }


        [Column("KisiSayisi", Order = 2, TypeName = "int")]
        [DefaultValue(0)]
        public int KisiSayisi { get; set; }

        [Column("DoluMu", Order = 3, TypeName = "bit")]
        [DefaultValue(false)]
        public bool DoluMu { get; set; }

        
    }
}
