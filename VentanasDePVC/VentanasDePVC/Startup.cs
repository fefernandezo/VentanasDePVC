using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VentanasDePVC.Startup))]
namespace VentanasDePVC
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
