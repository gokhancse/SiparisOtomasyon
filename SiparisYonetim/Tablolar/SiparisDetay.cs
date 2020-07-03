using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetim.Tablolar
{
    public class Siparis_Detay
    {
        [Key]
        public int SiparisDetayId { get; set; }

        public int SiparisId { get; set; }

        [ForeignKey("SiparisId")]
        public Siparis Siparis { get; set; }

        [Display(Name = "Müşteri")]
        public int SirketId { get; set; }

        [ForeignKey("SirketId")]
        public Sirket Sirket { get; set; }

        [Display(Name = "Ürün Adı")]
        public string UrunAdi { get; set; }

        [Display(Name = "Ürün Kodu")]
        public string Kod { get; set; }

        public int UrunId { get; set; }

        public int ToplamAdet { get; set; }



        [Display(Name = "Ürün Sipariş Notu")]
        [StringLength(500, ErrorMessage = "{0}, {1} karakterden fazla olamaz")]
        public string UrunNotu { get; set; }


        [Display(Name = "Detay")]
        [StringLength(100, ErrorMessage = "{0}, {1} karakterden fazla olamaz")]
        public string Detay { get; set; }

        public Guid ModelCheck { get; set; }
    }
}
