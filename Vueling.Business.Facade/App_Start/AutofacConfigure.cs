using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using Vueling.Business.Facade.Autofac_Modules;

namespace Vueling.Business.Facade.App_Start
{
    public class AutofacConfigure
    {
        protected AutofacConfigure() { }

        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new FacadeModule());

            var container = builder.Build();

            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration
                .DependencyResolver = resolver;

            return container;
        }

    }
}