using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VetryaBloodBowl.Startup))]
namespace VetryaBloodBowl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
