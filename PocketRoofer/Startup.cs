using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PocketRoofer.Startup))]
namespace PocketRoofer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
