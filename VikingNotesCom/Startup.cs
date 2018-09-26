using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VikingNotesCom.Startup))]
namespace VikingNotesCom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
