using Shared.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    internal class Log : ILog
    {
        private readonly ISetting _setting;

        public Log(ISetting setting)
        {
            _setting = setting;
        }

        public void Write(LogLevel level, string message)
        {
            bool enable = _setting.Get("IsLogEnabled", () => true);
            if(enable)
                Console.WriteLine($"{DateTimeOffset.Now} [{level}]: {message}");
        }
    }
}
