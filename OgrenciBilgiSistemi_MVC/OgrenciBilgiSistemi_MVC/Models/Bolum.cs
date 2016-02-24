using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace OgrenciBilgiSistemi_MVC.Models
{
    public class Bolum
    {
        [Key] //Anahtar Attributes tanımladık.
        public int Id { get; set; }

        [Required(ErrorMessage ="Lütfen bölüm adını giriniz.")] //Gerekli alan olduğu için Required Attributes tanımladık.
        [Display(Name ="Bölüm Adı")] //View üzerinde ki görünen ad için Display attributes tanımladık.
        public string Ad { get; set; }

        [Required(ErrorMessage ="Lütfen bölüm adresini giriniz.")] //Gerekli alan olduğu için Required Attributes tanımladık.
        [Display(Name ="Bölüm Adresi")] //View üzerinde ki görünen ad için Display attributes tanımladık.
        public string Adres { get; set; }

        [Required(ErrorMessage ="Lütfen bölüm kodunu giriniz.")] //Gerekli alan olduğu için Required Attributes tanımladık.
        [Display(Name ="Bölüm Kodu")] //View üzerinde ki görünen ad için Display attributes tanımladık.
        [MinLength(3,ErrorMessage ="Bölüm kodu 3 karakterden uzun olamaz.")] //Minumum değer tanımladık.
        [MaxLength(3,ErrorMessage ="Bölüm kodu 3 karakterden uzun olamaz.")] //Maximum değer tanımladık.
        public string Kod { get; set; }

        [Required(ErrorMessage ="Lütfen fakülte seçimi yapınız.")] //Gerekli alan olduğu için Required Attributes tanımladık.
        [Display(Name ="Fakülte")] //View üzerinde ki görünen ad için Display attributes tanımladık.
        public int FakulteId { get; set; }

        public virtual Fakulte Fakulte { get; set; } //Fakülte Bilgileri

        public virtual ICollection<Ogrenci> Ogrenciler { get; set; } //Ogrenci modelinden Ogrenciler adında Property tanımladık.
        public virtual ICollection<Ders> Dersler { get; set; } //Ders modelinden Dersler adında Property tanımladık.

    }
}