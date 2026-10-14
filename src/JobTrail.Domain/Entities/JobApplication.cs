using JobTrail.Domain.Common;
using JobTrail.Domain.Enums;

namespace JobTrail.Domain.Entities;

public class JobApplication:BaseEntity
{
    public Guid UserId { get; private set; }
    public Guid CompanyId { get; private set; }
    public ApplicationStatus Status { get; private set; }
    public string? JobUrl { get; private set; }
    public ApplicationSource? JobSource { get; private set; }
    public decimal? SalaryMin { get;private set; }
    public decimal? SalaryMax { get;private set; }
    public DateTimeOffset? AppliedAt { get; private set; }
    public string? Notes { get; private set; }
}