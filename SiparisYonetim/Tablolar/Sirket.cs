using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetim.Tablolar
{
    public class Sirket
    {
        [Key]
        public int SirketId { get; set; }

        [Display(Name = "Firma Adı")]
        [Required(ErrorMessage = "{0} zorunlu")]
        [StringLength(50, ErrorMessage = "{0}, {1} karakterden fazla olamaz")]
        public string SirketAdi { get; set; }

        [Display(Name = "Müşteri Kodu")]
        public string Kod { get; set; }

        [Display(Name = "Logo")]
        [StringLength(100, ErrorMessage = "{0}, {1} karakterden fazla olamaz")]
        public string LogoDosyaAdi { get; set; }

        [Display(Name = "Telefon 1")]
        public string Telefon { get; set; }

        [Display(Name = "Telefon 2")]
        public string Telefon2 { get; set; }

        [Display(Name = "E-posta")]
        public string Eposta { get; set; }
        public int? UstSirketId { get; set; }

        public bool Silindi { get; set; }

        [Display(Name = "Yetkili")]
        [StringLength(50, ErrorMessage = "{0}, {1} karakterden fazla olamaz")]
        public string Yetkili { get; set; }

        public virtual ICollection<Siparis> Siparisler { get; set; }

        public virtual ICollection<Siparis_Detay> SiparisDetaylar { get; set; }

    }
}
