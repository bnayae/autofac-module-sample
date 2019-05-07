using Autofac;
using FeatureB.Contracts;
using FeatureB.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    /// <summary>
    /// You should register all the public implementation of the project in here
    /// </summary>
    public class FeatureBModules : Module
    {
        public static readonly Module Default = new FeatureBModules();
        private FeatureBModules() { }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BeGood>()
                    .As<IBeGood>()
                    .SingleInstance();
            builder.RegisterType<BeSafe>()
                    .As<IBeSafe>()
                    .SingleInstance();
        }
    }
}
