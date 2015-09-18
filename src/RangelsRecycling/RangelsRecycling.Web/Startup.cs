using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RangelsRecycling.Web.Startup))]
namespace RangelsRecycling.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
