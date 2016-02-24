using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OgrenciBilgiSistemi_MVC.Models;

namespace OgrenciBilgiSistemi_MVC.Helpers
{
   
        public class EnumHelper
        {
            public static string GetirDonemAdi(int tip)
            {
                return GetirDonemAdi((Enumlar.DonemTipEnum)tip);
            }
            public static string GetirDonemAdi(Enumlar.DonemTipEnum tip)
            {
                switch (tip)
                {
                    case Enumlar.DonemTipEnum.Bahar: return "Bahar";
                    case Enumlar.DonemTipEnum.Guz: return "Güz";
                    case Enumlar.DonemTipEnum.Yaz: return "Yaz";
                    default: return "";
                }
            }
        }
    
}
