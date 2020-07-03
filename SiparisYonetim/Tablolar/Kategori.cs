using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SiparisYonetim.Tablolar
{
   public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }

        [Display(Name = "Kategori Adı")]
        [Required(ErrorMessage = "{0} zorunlu")]
        [StringLength(25, ErrorMessage = "{0}, {1} karakterden fazla olamaz.")]
        public string KategoriAdi { get; set; }

        public int SirketId { get; set; }

        public bool Silindi { get; set; }
    }
}
