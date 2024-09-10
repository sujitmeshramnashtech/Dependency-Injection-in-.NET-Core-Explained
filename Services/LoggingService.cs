// Services/LoggingService.cs
using System;

namespace DependencyInjectionExample.Services
{
    public class LoggingService : ILoggingService
    {
        public void LogInfo(string message)
        {
            // Logic for logging information
            Console.WriteLine($"INFO: {message}");
        }

        public void LogError(string message)
        {
            // Logic for logging errors
            Console.WriteLine($"ERROR: {message}");
        }
    }
}
