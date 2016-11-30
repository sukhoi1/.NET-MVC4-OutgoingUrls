using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OutgoingUrls.Startup))]
namespace OutgoingUrls
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
