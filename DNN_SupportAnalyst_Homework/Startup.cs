using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DNN_SupportAnalyst_Homework.Startup))]
namespace DNN_SupportAnalyst_Homework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
