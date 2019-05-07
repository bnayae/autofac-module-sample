using Shared.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    internal class Setting : ISetting
    {
        public T Get<T>(string key) where T : new() => new T();
        public T Get<T>(string key, Func<T> defaultValue) => defaultValue();
    }
}
