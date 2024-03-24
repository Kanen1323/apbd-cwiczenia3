namespace APBD3;

public class TemperatureException: Exception
{
    public TemperatureException()
    {
    }

    public TemperatureException(string? message) : base(message)
    {
    }

    public TemperatureException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}