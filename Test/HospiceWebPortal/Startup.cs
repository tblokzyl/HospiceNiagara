using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HospiceWebPortal.Startup))]
namespace HospiceWebPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
