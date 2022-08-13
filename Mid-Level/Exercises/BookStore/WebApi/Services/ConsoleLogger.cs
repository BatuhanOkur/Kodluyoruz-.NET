using System;

namespace WebApi.Services
{
    public interface ConsoleLogger:ILoggerService
    {
        public void Write(string message)
        {
            Console.WriteLine("[ConsoleLogger] - " + message);
        }

    }
}