using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewMidtermRedo.Startup))]
namespace NewMidtermRedo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
