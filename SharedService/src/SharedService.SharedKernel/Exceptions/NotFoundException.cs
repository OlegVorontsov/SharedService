using SharedService.SharedKernel.Errors;

namespace SharedService.SharedKernel.Exceptions;

public class NotFoundException : Exception
{
    public Error Error { get; }

    public NotFoundException(Error error)
        : base(error.Message)
    {
        Error = error;
    }
}