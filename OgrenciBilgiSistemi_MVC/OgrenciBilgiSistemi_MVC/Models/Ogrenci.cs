using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OgrenciBilgiSistemi_MVC.Models
{
    public class Ogrenci
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen öğrencinin adını giriniz!")]
        [Display(Name = "Adı")]
        public string Ad { get; set; }

        [Required(ErrorMessage ="Lütfen öğrencinin soyadını giriniz!")]
        [Display(Name ="Soyadı")]
        public string Soyad { get; set; }

        [Required]
        [MinLength(11,ErrorMessage ="T.C Kimlik Numarası 11 karakterden oluşmaktadır.")]
        [MaxLength(11,ErrorMessage ="T.C Kimlik Numarası 11 karakterden oluşmaktadır.")]
        [Display(Name ="T.C Kimlik No")]
        public string KimlikNo { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name ="E-Posta")]
        public string EPosta { get; set; }

        [Required]
        [DisplayFormat(DataFormatString ="{0:dd:MM:yyyy}")]
        [Display(Name ="Doğum Tarihi")]
        public DateTime DogumTarih { get; set; }

        [Required]
        [DisplayFormat(DataFormatString ="{0:dd:MM:yyyy}")]
        [Display(Name ="Giriş Tarihi")]
        public DateTime GirisTarih { get; set; }

        [Required]
        [DisplayFormat(DataFormatString ="{0:dd:MM:yyyy}")]
        [Display(Name ="Çıkış Tarihi")]
        public DateTime CikisTarih { get; set; }

        [Required]
        public int BolumId { get; set; }

        public virtual Bolum Bolum { get; set; }

        public virtual ICollection<OgrenciDonemDers> OgrenciDonemdersler{ get; set; }

    }
}