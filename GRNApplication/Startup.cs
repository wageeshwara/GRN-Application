using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GRNApplication.Startup))]
namespace GRNApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
