using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Top_Toolset.Startup))]
namespace Top_Toolset
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
