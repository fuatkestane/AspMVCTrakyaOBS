using OgrenciBilgiSistemi_MVC.Models.ViewModels;
using OgrenciBilgiSistemi_MVC.Repositories;
using System.Web.Mvc;

namespace OgrenciBilgiSistemi_MVC.Areas.Yonetim.Controllers
{
    public class YonetimController : Controller
    {
        UyelikRepository _uyelik = new UyelikRepository();

        [AllowAnonymous]
        public ActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult GirisYap(NUyeGiris model,string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var girisSonuc = _uyelik.GirisYap(model.KullaniciAd, model.Sifre, Models.Enumlar.UyeTip.BilgiIslem);
                if (girisSonuc.BasariliMi)
                {
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("FakulteListesi", "Fakulte");
                    }
                }
                else
                {
                    ModelState.AddModelError("", girisSonuc.Mesaj);
                }
            }
            return View(model);
        }

        [Authorize(Roles ="BilgiIslem")]
        public ActionResult CikisYap()
        {
            _uyelik.CikisYap();
            return RedirectToAction("GirisYap", "Yonetim");
        }
    }
}