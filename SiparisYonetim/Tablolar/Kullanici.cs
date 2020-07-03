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
    public class Kullanici
    {
        [Key]
        public int KullaniciId { get; set; }

        [Required(ErrorMessage = "Müşteri Seçiniz")]
        public int SirketId { get; set; }

        [ForeignKey("SirketId")]
        public virtual Sirket Sirket { get; set; }

        [Display(Name = "Ad")]
        [StringLength(25, ErrorMessage = "{0}, {1} karakterden fazla olamaz")]
        [Required(ErrorMessage = "{0} zorunlu")]
        public string Ad { get; set; }

        [Display(Name = "Soyad")]
        [StringLength(25, ErrorMessage = "{0}, {1} karakterden fazla olamaz")]
        [Required(ErrorMessage = "{0} zorunlu")]
        public string Soyad { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "{0} zorunlu")]
        [StringLength(255, ErrorMessage = "{0}, {1} karakterden fazla olamaz")]
        public string K_Adi { get; set; }

        [Display(Name = "Parola")]
        [Required(ErrorMessage = "{0} zorunlu")]
        [StringLength(16, ErrorMessage = "{0}, {1} karakterden fazla olamaz")]
        public string Parola { get; set; }

        [Display(Name = "Son Başarılı Giriş Tarihi")]
        public DateTime? SonGirisTarihi { get; set; }

        [Display(Name = "Son Başarısız Giriş Tarihi")]
        public DateTime SonBasarisizGirisTarihi { get; set; }

        public int YanlisGirisAdedi { get; set; }

        public ICollection<Siparis> Siparisler { get; set; }

    }
}
