using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoFinal2._0.Startup))]
namespace ProyectoFinal2._0
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
