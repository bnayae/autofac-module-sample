using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FeatureA.Contracts
{
    public interface IWorker
    {
        Task Work(CancellationToken cancellationToken = default);
    }
}
