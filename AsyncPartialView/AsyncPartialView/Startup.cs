using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AsyncPartialView.Startup))]
namespace AsyncPartialView
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
