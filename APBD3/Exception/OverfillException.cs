namespace APBD3;

public class OverfillException : Exception
{
    public OverfillException(): base("You want to insert more than the container can hold")
    {
    }

    public OverfillException(string? message) : base(message)
    {
    }

    public OverfillException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}