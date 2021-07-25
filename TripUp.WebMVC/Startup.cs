using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TripUp.WebMVC.Startup))]
namespace TripUp.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
