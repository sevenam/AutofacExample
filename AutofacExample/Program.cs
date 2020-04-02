using Autofac;
using AutofacExample.DependencyInjection;
using AutofacExample.Interfaces;
using System;

namespace AutofacExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerService.GetDiContainer();

            using(var appScope = container.BeginLifetimeScope())
            {
                var app = appScope.Resolve<IApp>();
                app.Run();
            }

            Console.ReadLine();
        }
    }
}
