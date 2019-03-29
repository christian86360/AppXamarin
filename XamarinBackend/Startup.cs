using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XamarinBackend.Startup))]
namespace XamarinBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
