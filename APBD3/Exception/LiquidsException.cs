namespace APBD3;

public class LiquidsException : Exception
{
    public LiquidsException() : base("You cannot pour substance into a container that contains another substance")
    {
    }

    public LiquidsException(string? message) : base(message)
    {
    }

    public LiquidsException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}