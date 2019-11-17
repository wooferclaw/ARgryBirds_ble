using Owin;
using System.Web.Http;

namespace BLEConsole
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();
            config.EnableCors();
            config.Routes.MapHttpRoute(
                name: "queueUpdateApi",
                routeTemplate: "api/{controller}/{color}",
                defaults: new { id = RouteParameter.Optional }
            );
            appBuilder.UseWebApi(config);
        }
    }
}