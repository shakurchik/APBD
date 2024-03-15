using System.Runtime.Serialization;

namespace Task_3;

public class OverfillException:Exception
{
    public OverfillException()
    {
    }

    protected OverfillException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public OverfillException(string? message) : base(message)
    {
    }

    public OverfillException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}