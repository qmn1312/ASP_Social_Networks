using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ass07_2.Startup))]
namespace Ass07_2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
