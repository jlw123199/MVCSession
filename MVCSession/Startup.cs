using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCSession.Startup))]
namespace MVCSession
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
