using System.Web.Http;

namespace Backend
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DataStorage.Seed();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
