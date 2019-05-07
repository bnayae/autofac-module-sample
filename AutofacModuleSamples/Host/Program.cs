using Autofac;
using FeatureA.Contracts;
using System;
using System.Threading.Tasks;

namespace Host
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(InfraModules.Default);
            builder.RegisterModule(FeatureAModules.Default);
            builder.RegisterModule(FeatureBModules.Default);

            var ioc = builder.Build();
            var worker = ioc.Resolve<IWorker>();
            await worker.Work().ConfigureAwait(false);

            Console.ReadKey();
        }
    }
}
