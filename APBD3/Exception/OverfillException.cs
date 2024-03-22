﻿namespace APBD3;

public class OverfillException : Exception
{
    public OverfillException()
    {
    }

    public OverfillException(string? message) : base("Error")
    {
    }

    public OverfillException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}