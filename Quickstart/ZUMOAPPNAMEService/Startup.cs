using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MyTripPlannerService.Startup))]

namespace MyTripPlannerService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}