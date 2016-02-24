using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OgrenciBilgiSistemi_MVC.Models
{
    public class Fakulte
    {
        [Key] //Anahtar Attributes tanımladık.
        public int Id { get; set; }    

        [Required(ErrorMessage ="Lütfen fakülte adını yazınız")] //Gerekli alan olduğu için Required Attributes tanımladık.
        [Display(Name ="Fakülte Adı")] //View üzerinde ki görünen ad için Display attributes tanımladık.
        public string Ad { get; set; }

        [Required(ErrorMessage ="Lütfen fakülte adresini yazınız.")] //Gerekli alan olduğu için Required Attributes tanımladık.
        [Display(Name ="Fakülte Adresi")] //View üzerinde ki görünen ad için Display attributes tanımladık.
        public string Adres { get; set; }

        public virtual ICollection<Bolum> Bolumler { get; set; } //Bolum Modelinden Bolumler Adında Property tanımladık.
    }
}