using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi_MVC.Models
{
    public class Donem
    {
        [Key] //Anahtar Attributes tanımladık.
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen dönemin yılını seçiniz.")] //Gerekli alan olduğu için Required Attributes tanımladık.
        [Display(Name = "Dönem Yılı")] //View üzerinde ki görünen ad için Display attributes tanımladık.
        public int Yil { get; set; }

        [Required(ErrorMessage = "Lütfen dönemin tipini seçiniz.")] //Gerekli alan olduğu için Required Attributes tanımladık.
        [Display(Name = "Dönem Tipi")] //View üzerinde ki görünen ad için Display attributes tanımladık.
        public int DonemTip { get; set; }

        public virtual ICollection<DonemDers> DonemDersler { get; set; } //DonemDers Modelinden DonemDersler adında Property tanımladık.
    }
}
