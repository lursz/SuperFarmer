namespace SuperFarmer.Exceptions;

public class TimeOutException : Exception
{
    public TimeOutException(string message) : base(message)
    {
    }
}