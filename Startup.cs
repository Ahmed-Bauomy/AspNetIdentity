using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetIdentityExtend.Startup))]
namespace AspNetIdentityExtend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
