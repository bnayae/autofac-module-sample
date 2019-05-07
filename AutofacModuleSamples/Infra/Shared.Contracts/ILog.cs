using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Contracts
{
    public interface ILog
    {
        void Write(LogLevel level, string message);
    }
}
