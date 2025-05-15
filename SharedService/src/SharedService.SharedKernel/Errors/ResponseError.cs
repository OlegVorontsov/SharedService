namespace SharedService.SharedKernel.Errors;

public record ResponseError(
    string? ErrorCode,
    string? ErrorMessage,
    string? InvalidField);