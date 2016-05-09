using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PNACCompetitionsDbFirst.Startup))]
namespace PNACCompetitionsDbFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
