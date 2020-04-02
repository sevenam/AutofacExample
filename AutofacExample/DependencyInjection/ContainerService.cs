using Autofac;
using AutofacExample.Interfaces;
using Core.Interfaces;
using Core.Services;

namespace AutofacExample.DependencyInjection
{
    public static class ContainerService
    {
        public static IContainer GetDiContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<DataAccess>().As<IDataAccess>();
            builder.RegisterType<DataModifier>().As<IDataModifier>();
            builder.RegisterType<App>().As<IApp>();
            var container = builder.Build();

            return container;
        }

    }
}
