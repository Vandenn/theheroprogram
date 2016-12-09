using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(theheroprogram.Startup))]
namespace theheroprogram
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
