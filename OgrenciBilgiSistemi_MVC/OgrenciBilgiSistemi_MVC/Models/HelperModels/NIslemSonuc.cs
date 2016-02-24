using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi_MVC.Models.HelperModels
{
    public class NIslemSonuc
    {
        public bool BasariliMi { get; set; }
        public string Mesaj { get; set; }
    }

    public class NIslemSonuc<T> : NIslemSonuc
    {
        public T Veri { get; set; }
    }
}
