using System.Net;
using Microsoft.AspNetCore.Http;
using SharedService.SharedKernel.Errors;
using SharedService.SharedKernel.Models;

namespace SharedService.Framework.EndpointResults;

public sealed class ErrorsResult : IResult
{
    private readonly ErrorList _errors;

    public ErrorsResult(Error error)
    {
        _errors = error.ToErrors();
    }

    public ErrorsResult(ErrorList errors)
    {
        _errors = errors;
    }

    public Task ExecuteAsync(HttpContext httpContext)
    {
        ArgumentNullException.ThrowIfNull(httpContext);

        if (!_errors.Any())
        {
            httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            return httpContext.Response.WriteAsJsonAsync(Envelope.Error(_errors));
        }

        var distinctErrorTypes = _errors
            .Select(x => x.Type)
            .Distinct()
            .ToList();

        int statusCode = distinctErrorTypes.Count > 1 ?
            StatusCodes.Status500InternalServerError :
            StatusCodesHelper.GetStatusCodeForErrorType(distinctErrorTypes.First());

        var envelope = Envelope.Error(_errors);
        httpContext.Response.StatusCode = statusCode;

        return httpContext.Response.WriteAsJsonAsync(envelope);
    }
}