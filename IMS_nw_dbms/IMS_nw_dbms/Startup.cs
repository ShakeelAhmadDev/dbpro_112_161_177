using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IMS_nw_dbms.Startup))]
namespace IMS_nw_dbms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
