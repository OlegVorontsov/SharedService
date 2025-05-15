using CSharpFunctionalExtensions;
using SharedService.SharedKernel.Errors;

namespace SharedService.Core.Abstractions;

public interface IQueryHandler<TResponse, in TQuery>
    where TQuery : IQuery
{
    public Task<TResponse> Handle(
        TQuery query,
        CancellationToken cancellationToken = default);
}

public interface IQueryHandlerWithResult<TResponse, in TQuery>
    where TQuery : IQuery
{
    public Task<Result<TResponse, ErrorList>> Handle(
        TQuery query,
        CancellationToken cancellationToken = default);
}