using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Design.Startup))]
namespace Design
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
