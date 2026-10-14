namespace JobTrail.Domain.Common;

public class BaseEntity
{
    public Guid Id { get; private set; }
    public DateTimeOffset CreatedAt { get; private set; }
    public DateTimeOffset UpdatedAt { get; private set; }

    protected BaseEntity()
    {
        Id = Guid.Empty;
        CreatedAt = DateTimeOffset.UtcNow;
        UpdatedAt = DateTimeOffset.UtcNow;
    }
}