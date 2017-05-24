using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HEManagement.Startup))]
namespace HEManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
