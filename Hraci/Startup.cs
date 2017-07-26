using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hraci.Startup))]
namespace Hraci
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
