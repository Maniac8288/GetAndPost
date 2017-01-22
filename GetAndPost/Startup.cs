using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GetAndPost.Startup))]
namespace GetAndPost
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
