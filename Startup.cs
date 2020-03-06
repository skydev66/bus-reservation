//import library
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineBusReservationV6.Startup))]
namespace OnlineBusReservationV6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //Configure the app
            ConfigureAuth(app);
        }
    }
}
