using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SaberPro.Startup))]
namespace SaberPro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
