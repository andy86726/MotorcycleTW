using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MotorcycleTW.Startup))]
namespace MotorcycleTW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
