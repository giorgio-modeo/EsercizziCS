using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_PrestitiBibblioteca.Startup))]
namespace MVC_PrestitiBibblioteca
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
