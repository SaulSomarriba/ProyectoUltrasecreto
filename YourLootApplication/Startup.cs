using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YourLootApplication.Startup))]
namespace YourLootApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
