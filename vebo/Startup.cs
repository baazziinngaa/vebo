using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vebo.Startup))]
namespace vebo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
