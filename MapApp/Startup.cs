using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MapApp.Startup))]
namespace MapApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
