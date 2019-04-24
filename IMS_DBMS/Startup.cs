using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IMS_DBMS.Startup))]
namespace IMS_DBMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
