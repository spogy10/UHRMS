using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UHRMS.Startup))]
namespace UHRMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
