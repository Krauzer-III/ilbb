using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ATOM.Startup))]
namespace ATOM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
