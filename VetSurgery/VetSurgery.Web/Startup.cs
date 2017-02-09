using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VetSurgery.Web.Startup))]
namespace VetSurgery.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
