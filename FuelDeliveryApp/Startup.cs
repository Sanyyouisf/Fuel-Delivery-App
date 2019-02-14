using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FuelDeliveryApp.Startup))]
namespace FuelDeliveryApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
