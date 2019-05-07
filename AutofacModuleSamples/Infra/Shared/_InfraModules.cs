using Autofac;
using Shared;
using Shared.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    /// <summary>
    /// You should register all the public implementation of the project in here
    /// </summary>
    public class InfraModules : Module
    {
        public static readonly Module Default = new InfraModules();
        private InfraModules() { }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Log>()
                    .As<ILog>()
                    .SingleInstance();
            builder.RegisterType<Setting>()
                    .As<ISetting>()
                    .SingleInstance();
        }
    }
}
