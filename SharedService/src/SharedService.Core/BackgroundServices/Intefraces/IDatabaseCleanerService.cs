namespace SharedService.Core.BackgroundServices.Intefraces;

public interface IDatabaseCleanerService
{
    Task CleanTablesAsync(
        TimeSpan timeToRestore,
        CancellationToken stoppingToken = default);
}