namespace TaskTracker;

public class EntityNotFoundException : Exception
{
    public EntityNotFoundException(string message) : base(message)
    {
    }
}

public class InvalidRequestException : Exception
{
    public InvalidRequestException(string message) : base(message)
    {
    }
}