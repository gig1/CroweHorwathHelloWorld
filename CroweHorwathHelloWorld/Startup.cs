using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CroweHorwathHelloWorld.Startup))]
namespace CroweHorwathHelloWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
