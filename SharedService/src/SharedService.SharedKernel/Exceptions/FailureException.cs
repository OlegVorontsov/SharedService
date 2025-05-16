using SharedService.SharedKernel.Errors;

namespace SharedService.SharedKernel.Exceptions;

public class FailureException : Exception
{
    public Error Error { get; }

    public FailureException(Error error)
        : base(error.Message)
    {
        Error = error;
    }
}