using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GroupWebsite.Startup))]
namespace GroupWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
