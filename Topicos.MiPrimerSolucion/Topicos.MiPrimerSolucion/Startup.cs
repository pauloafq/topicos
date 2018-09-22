using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Topicos.MiPrimerSolucion.Startup))]
namespace Topicos.MiPrimerSolucion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
