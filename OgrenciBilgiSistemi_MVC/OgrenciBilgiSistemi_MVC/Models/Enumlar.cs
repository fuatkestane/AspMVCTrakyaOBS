using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi_MVC.Models
{
    public class Enumlar
    {
        public enum DonemTipEnum
        {
            Guz=1,
            Bahar=2,
            Yaz=3
        }

        public enum BasariDurumTipEnum
        {
            Basarili=1,
            Basarisiz=2
        }

        public enum UyeTip
        {
            Ogrenci=1,
            OgretimGorevlisi=2,
            BilgiIslem=3
        }
    }
}
