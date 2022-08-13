using System;

namespace WebApi.Services
{
    public interface DBLogger:ILoggerService
    {
        public new void Write(string message)
        {
            Console.WriteLine("[DBLogger] - " + message);
        }

    }
}