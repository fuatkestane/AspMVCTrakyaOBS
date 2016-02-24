using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi_MVC.Models.ViewModels
{
    public class NUyeGiris
    {
        [Required]
        [Display(Name ="Kullanıcı Adı")]
        public string KullaniciAd { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Şifre")]
        public string Sifre { get; set; }
    }
}
