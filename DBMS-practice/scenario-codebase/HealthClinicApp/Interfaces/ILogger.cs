namespace HealthClinicApp.Interfaces
{
    /// <summary>
    /// Generic logger interface.
    /// Supports file and async logging.
    /// </summary>
    public interface ILogger<T>
    {
        void Log(T message);
    }
}
