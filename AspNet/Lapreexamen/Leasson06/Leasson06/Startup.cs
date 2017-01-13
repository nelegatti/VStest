using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Leasson06.Startup))]
namespace Leasson06
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
