using SharedService.SharedKernel.Errors;

namespace SharedService.SharedKernel.Exceptions;

public class ConflictException : Exception
{
    public Error Error { get; }

    public ConflictException(Error error)
        : base(error.Message)
    {
        Error = error;
    }
}