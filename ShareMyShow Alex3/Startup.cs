using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShareMyShow_Alex3.Startup))]
namespace ShareMyShow_Alex3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
