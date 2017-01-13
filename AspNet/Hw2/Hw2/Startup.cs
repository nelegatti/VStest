using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hw2.Startup))]
namespace Hw2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
