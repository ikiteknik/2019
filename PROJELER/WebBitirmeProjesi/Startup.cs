using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebBitirmeProjesi.Startup))]
namespace WebBitirmeProjesi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
