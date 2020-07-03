using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetim.Tablolar
{
    public class Siparis
    {
        [Key]
        public int SiparisId { get; set; }

        [Display(Name = "Müşteri")]
        public int SirketId { get; set; }

        [ForeignKey("SirketId")]
        public virtual Sirket Sirket { get; set; }

        public int SiparisVerenSirketId { get; set; }

        [ForeignKey("SiparisVerenSirketId")]
        public Sirket SiparisVerenSirket { get; set; }

        [Display(Name = "Sipariş Tarihi")]
        public DateTime SiparisTarihi { get; set; }

        [Display(Name = "Teslim Tarihi")]
        public DateTime TeslimTarihi { get; set; }

        [Display(Name = "Sipariş Notu")]
        [StringLength(250, ErrorMessage = "{0}, {1} karakterden fazla olamaz")]
        public string SiparisNotu { get; set; }

        public int KullaniciId { get; set; }

        [ForeignKey("KullaniciId")]
        public Kullanici Kullanici { get; set; }

        public virtual ICollection<Siparis_Detay> SiparisDetaylar { get; set; }

        public int ToplamAdet { get; set; }

        public double ToplamAgirlik { get; set; }

        public int ToplamUrunCesidi { get; set; }
    }
}
