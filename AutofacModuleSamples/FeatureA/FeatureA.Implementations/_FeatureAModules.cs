using Autofac;
using FeatureA.Contracts;
using FeatureA.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    /// <summary>
    /// You should register all the public implementation of the project in here
    /// </summary>
    public class FeatureAModules: Module
    {
        public static readonly Module Default = new FeatureAModules();
        private FeatureAModules(){ }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Worker>()
                    .As<IWorker>()
                    .SingleInstance();
        }
    }
}
