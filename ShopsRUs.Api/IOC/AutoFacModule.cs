using Autofac;
using ShopsRUs.Application.Abstract;

namespace ShopsRUs.Api.IOC
{
    public class AutoFacModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(IService<>).Assembly) 
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
