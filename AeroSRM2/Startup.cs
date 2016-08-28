using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AeroSRM2.Startup))]
namespace AeroSRM2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
