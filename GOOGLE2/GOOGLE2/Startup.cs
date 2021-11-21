using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GOOGLE2.Startup))]
namespace GOOGLE2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
