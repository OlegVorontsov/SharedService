using SharedService.SharedKernel.Errors;

namespace SharedService.SharedKernel.Exceptions;

public class ValidationException : Exception
{
    public Error Error { get; }

    public ValidationException(Error error)
        : base(error.Message)
    {
        Error = error;
    }
}