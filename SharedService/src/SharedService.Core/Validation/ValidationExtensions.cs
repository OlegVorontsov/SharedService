using FluentValidation.Results;
using SharedService.SharedKernel.Errors;

namespace SharedService.Core.Validation;

public static class ValidationExtensions
{
    public static ErrorList ToList(this ValidationResult validationResult)
    {
        var validationErrors = validationResult.Errors;

        var errors = from validationError in validationErrors
                     let errorMessage = validationError.ErrorMessage
                     let error = Error.Deserialize(errorMessage)
                     select Error.Validation(
                         error.Code,
                         error.Message,
                         validationError.PropertyName);

        return errors.ToList();
    }
}