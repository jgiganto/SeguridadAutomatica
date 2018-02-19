using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeguridadAutomatica.Startup))]
namespace SeguridadAutomatica
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
