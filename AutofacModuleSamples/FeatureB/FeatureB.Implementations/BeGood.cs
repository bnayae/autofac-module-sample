using FeatureB.Contracts;
using Shared.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FeatureB.Implementations
{
    public class BeGood : IBeGood
    {
        private readonly ILog _log;

        public BeGood(ILog log)
        {
            _log = log;
        }
        public void MakeGood()
        {
            _log.Write(LogLevel.Info, "Making good");
            Console.WriteLine("May the force be with you");
        }
    }
}
