using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormEx1.Startup))]
namespace WebFormEx1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
