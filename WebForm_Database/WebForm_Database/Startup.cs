using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebForm_Database.Startup))]
namespace WebForm_Database
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
