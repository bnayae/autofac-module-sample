using FeatureA.Contracts;
using FeatureB.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FeatureA.Implementations
{
    internal class Worker : IWorker
    {
        private readonly IBeGood _beGood;
        private readonly IBeSafe _beSafe;

        public Worker(IBeGood beGood, IBeSafe beSafe)
        {
            _beGood = beGood;
            _beSafe = beSafe;
        }
        public async Task Work(CancellationToken cancellationToken = default)
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(1000).ConfigureAwait(false);
                _beGood.MakeGood();
                _beSafe.Protect();
            }
        }
    }
}
