using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MohammmedGit.Startup))]
namespace MohammmedGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
