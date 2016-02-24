using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OgrenciBilgiSistemi_MVC.Models
{
    public class Ders
    {
        [Key] //Anahtar Attributes tanımladık.
        public int Id { get; set; }

        [Required(ErrorMessage ="Lütfen dersin adını giriniz.")] //Gerekli alan olduğu için Required Attributes tanımladık.
        [Display(Name ="Ders Adı")] //View üzerinde ki görünen ad için Display attributes tanımladık.
        public string Ad { get; set; }

        [Required(ErrorMessage ="Lütfen dersin kodunu giriniz.")] //Gerekli alan olduğu için Required Attributes tanımladık.
        [Display(Name ="Ders Kodu")] //View üzerinde ki görünen ad için Display attributes tanımladık.
        [MinLength(3,ErrorMessage ="Ders kodu 3 karakterden oluşmalıdır.")] //Minumum değerleri girdik.
        [MaxLength(3,ErrorMessage ="Ders kodu 3 karakterden oluşmalıdır.")] //Maximum değerleri girdik.
        public string Kod { get; set; }

        [Required]
        public int BolumId { get; set; } //Bölüme ait ders Property bilgisi.

        public virtual Bolum Bolum { get; set; }

        public virtual ICollection<DonemDers> DonemDersler { get; set; } //DonemDers Modelinden DonemDersler adında Property tanımladık.
    }
}