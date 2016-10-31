using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Restaurants.UI.Startup))]
namespace Restaurants.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
