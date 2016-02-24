namespace OgrenciBilgiSistemi_MVC.Migrations

{
    using OgrenciBilgiSistemi_MVC.Models;
    using OgrenciBilgiSistemi_MVC.Repositories;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Collections.Generic;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class OBSIdentityContextConfiguration : DbMigrationsConfiguration<OBSIdentityContext>
    {
        public OBSIdentityContextConfiguration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OBSIdentityContext context)
        {
            var userManager = new UserManager<ApplicationUser>
                (new UserStore<ApplicationUser>(new OBSIdentityContext()));

            var roleManager = new RoleManager<IdentityRole>
                (new RoleStore<IdentityRole>
                (new OBSIdentityContext()));

            //Rolleri oluþturma
            List<string> roller = new List<string>() { "BilgiIslem", "Ogrenci", "OgretimGorevlisi" };
            foreach (string rolAdi in roller)
            {
                if (roleManager.RoleExists(rolAdi) == false) //Eðer rol veritabanýnda yok ise rolü oluþtur
                    roleManager.Create(new IdentityRole(rolAdi));
            }

            string bilgiIslemKullaniciAdi = "fuat";
            if (userManager.FindByName(bilgiIslemKullaniciAdi) == null) //fuat isimli kullanýcý yoksa
            {
                //Kullanýcýyý oluþtur
                ApplicationUser bilgiIslemKullanicisi = new ApplicationUser()
                {
                    UserName = "fuat"
                };
                var kullaniciKayitSonuc = userManager.Create(bilgiIslemKullanicisi, "123456");

                //Kullanýcý oluþtuysa kullanýcýyý "BilgiIslem" rolüne ekle
                if (kullaniciKayitSonuc.Succeeded)
                {
                    userManager.AddToRole(bilgiIslemKullanicisi.Id, "BilgiIslem");
                }
            }
        }
    }
}
