using SiparisYonetim.Tablolar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetim.Tablolar
{
    public class Urun
    {
        [Key]
        public int UrunId { get; set; }

        [Display(Name = "Ürün Adı")]
        [StringLength(25, ErrorMessage = "{0}, {1} karakterden fazla olamaz")]
        [Required(ErrorMessage = "{0} zorunlu")]
        public string Adi { get; set; }

        [Display(Name = "Ürün Kodu")]
        [StringLength(25, ErrorMessage = "{0}, {1} karakterden fazla olamaz")]
        [Required(ErrorMessage = "{0} zorunlu")]
        public string Kod { get; set; }

        public int SirketId { get; set; }

        [ForeignKey("SirketId")]
        public virtual Sirket Sirket { get; set; }

        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }

        [DefaultValue(false)]
        public bool YeniUrun { get; set; }

        public string UrunResmi { get; set; }

        public string UrunResmiBuyuk { get; set; }

        [Display(Name = "Gram")]
        [Required(ErrorMessage = "{0} zorunlu")]
        public double Miktar { get; set; }

        [Display(Name = "Ayar")]
        [StringLength(16, ErrorMessage = "{0}, {1} karakterden fazla olamaz")]
        public string Ayar { get; set; }

        public DateTime EklenmeTarihi { get; set; }

        [Display(Name = "Detay")]
        [StringLength(100, ErrorMessage = "{0}, {1} karakterden fazla olamaz")]
        public string Detay { get; set; }

        public string Bilesen_Adi { get; set; }

        public string Bilesen_Sayisi { get; set; }

        public string Bilesen_Agirligi { get; set; }

        public string Bilesen_Mikronu { get; set; }

        public string Bilesen_Santimi { get; set; }

        public string Bilesen_Capi { get; set; }
    }
}
