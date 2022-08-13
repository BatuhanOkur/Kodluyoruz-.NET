using System;

namespace WebApi.Services
{
    public interface ConsoleLogger : ILoggerService
    {
        public new void Write(string message)
        {
            Console.WriteLine("[ConsoleLogger] - " + message);
        }

    }
}