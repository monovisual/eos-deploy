using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eos_Placeholder.Startup))]
namespace Eos_Placeholder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
