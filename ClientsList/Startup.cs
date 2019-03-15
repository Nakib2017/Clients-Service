using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClientsList.Startup))]
namespace ClientsList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
