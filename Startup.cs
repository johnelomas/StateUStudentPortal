using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StateUStudentPortal.Startup))]
namespace StateUStudentPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
