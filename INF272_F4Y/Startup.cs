using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(INF272_F4Y.Startup))]
namespace INF272_F4Y
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
