using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EjercicioMVC.Startup))]
namespace EjercicioMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
