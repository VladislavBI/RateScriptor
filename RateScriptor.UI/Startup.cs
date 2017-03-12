using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RateScriptor.UI.Startup))]
namespace RateScriptor.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
