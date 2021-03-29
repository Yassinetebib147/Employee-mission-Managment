using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PI_Dotnet.Startup))]
namespace PI_Dotnet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
