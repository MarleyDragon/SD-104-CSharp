using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CatDragonInn.Startup))]
namespace CatDragonInn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
