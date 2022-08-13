using System;

namespace WebApi.Services
{
    public interface DBLogger:ILoggerService
    {
        public void Write(string message)
        {
            Console.WriteLine("[DBLogger] - " + message);
        }

    }
}