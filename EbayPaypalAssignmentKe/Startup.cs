using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EbayPaypalAssignmentKe.Startup))]
namespace EbayPaypalAssignmentKe
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
