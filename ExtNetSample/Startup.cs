using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExtNetSample.Startup))]
namespace ExtNetSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
