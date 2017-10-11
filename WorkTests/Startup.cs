using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkTests.Startup))]
namespace WorkTests
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
