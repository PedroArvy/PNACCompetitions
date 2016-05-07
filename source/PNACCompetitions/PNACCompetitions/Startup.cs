using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PNACCompetitions.Startup))]
namespace PNACCompetitions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
