namespace MyBackendApi.Domain.Common;

public abstract record BaseEvent
{
    public DateTimeOffset DateOccurred { get; init; } = DateTimeOffset.UtcNow;
}
