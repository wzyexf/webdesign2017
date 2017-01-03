using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(design.Startup))]
namespace design
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
