using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MobСardNews.Startup))]
namespace MobСardNews
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
