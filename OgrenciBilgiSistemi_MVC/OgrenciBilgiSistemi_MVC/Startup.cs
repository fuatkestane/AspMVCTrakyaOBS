using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OgrenciBilgiSistemi_MVC.Startup))]
namespace OgrenciBilgiSistemi_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
