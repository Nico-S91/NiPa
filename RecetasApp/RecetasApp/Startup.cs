using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecetasApp.Startup))]
namespace RecetasApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
