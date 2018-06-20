using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_FirstProject.Startup))]
namespace MVC_FirstProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
