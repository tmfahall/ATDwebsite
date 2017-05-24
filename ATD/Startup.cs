using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ATD.Startup))]
namespace ATD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
