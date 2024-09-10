// Services/ILoggingService.cs
namespace DependencyInjectionExample.Services
{
    public interface ILoggingService
    {
        void LogInfo(string message);
        void LogError(string message);
    }
}
