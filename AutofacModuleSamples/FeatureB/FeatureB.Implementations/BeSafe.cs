using FeatureB.Contracts;
using Shared.Contracts;
using System;

namespace FeatureB.Implementations
{
    internal class BeSafe : IBeSafe
    {
        private readonly ILog _log;

        public BeSafe(ILog log)
        {
            _log = log;
        }

        public void Protect()
        {
            _log.Write(LogLevel.Info, "Now it safer");
            Console.WriteLine("Protecting");
        }
    }
}
