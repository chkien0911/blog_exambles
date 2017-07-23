using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJs4.Startup))]
namespace AngularJs4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
