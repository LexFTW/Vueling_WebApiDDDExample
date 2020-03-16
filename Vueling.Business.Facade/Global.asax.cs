using System.Web;
using System.Web.Http;

namespace Vueling.Business.Facade
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            // GlobalConfiguration for Autofac Module
        }
    }
}
