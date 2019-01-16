using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChemOil.Startup))]
namespace ChemOil
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
