using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace Otel_Rezervasyon_Sistemi.EF
{
    [Table("Musteri_Tablo")]
    public class Musteri
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order =3)]
        public int MusteriId { get; set; }

        [ForeignKey("Oda")]
        [Required]
        [Column("OdaID", Order = 4, TypeName = "int")]
        public int OdaId { get; set; }

        public Oda Oda { get; set; }



        private string _tcNo;

        [Column("KimlikNo", TypeName = "nvarchar", Order = 0)]
        [Required][MaxLength(11)]
        public string TcNO
        {

            get { return _tcNo; }
            set
            {
                var regexItem = new Regex("^[0-9]*$");

                if (value.Length == 11 && regexItem.IsMatch(value))
                {
                    _tcNo = value;
                }
                else
                {
                    throw new Exception("Sadece 11 Haneli Rakam Girişi Yapınız.!");
                }

            }
        }


        private string _ad;

        [Column("Ad", TypeName = "nvarchar", Order = 1)]
        [Required]
        [StringLength(30)]
        public string Ad
        {
            get { return _ad; }
            set
            {
                var regexItem = new Regex("^[a-zA-Z\x20]*$");
                if (regexItem.IsMatch(value) && !string.IsNullOrWhiteSpace(value))
                {
                    _ad = value;
                }
                else
                {
                    throw new Exception("Lütfen Ad Girerken Özel Karakter veya Rakam Kullanmayınız.!");
                }

            }
        }

        private string _soyad;

        [Column("Soyad", TypeName = "nvarchar", Order = 2)]
        [Required]
        [StringLength(30)]
        public string Soyad
        {
            get { return _soyad; }
            set
            {
                var regexItem = new Regex("^[a-zA-Z\x20]*$");
                if (regexItem.IsMatch(value) && !string.IsNullOrWhiteSpace(value))
                {
                    _soyad = value;
                }
                else
                {
                    throw new Exception("Lütfen Soyad Girerken Özel Karakter veya Rakam Kullanmayınız.!");
                }

            }
        }

    }
}
