using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tutorial_0304.Startup))]
namespace Tutorial_0304
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
