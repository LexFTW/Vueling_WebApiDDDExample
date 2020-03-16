using System.Reflection;
using Autofac;
using Autofac.Integration.WebApi;
using Vueling.Application.Logic.Contracts;
using Vueling.Application.Logic.Implementations;
using Vueling.Domain.Entities;

namespace Vueling.Business.Facade.Autofac_Modules
{
    public class FacadeModule : Autofac.Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder
                .RegisterType<StudentService>()
                .As<IService<Student>>();

            //builder.RegisterModule(new BusinessModule());
            base.Load(builder);

        }

    }
}