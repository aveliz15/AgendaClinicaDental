using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UI_ClinicaDental.Startup))]
namespace UI_ClinicaDental
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
