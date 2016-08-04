using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevOps.Web.Startup))]
namespace DevOps.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
