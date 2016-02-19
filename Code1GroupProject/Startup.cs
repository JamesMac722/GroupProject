using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Code1GroupProject.Startup))]
namespace Code1GroupProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
