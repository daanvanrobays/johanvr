using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JohanVanRobays.Startup))]
namespace JohanVanRobays
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
