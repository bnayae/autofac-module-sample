using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Contracts
{
    public interface ISetting
    {
        T Get<T>(string key) where T:new();
        T Get<T>(string key, Func<T> defaultValue);
    }
}
