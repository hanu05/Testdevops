using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Testdevops.Startup))]
namespace Testdevops
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
