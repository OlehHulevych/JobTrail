using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

using System.Runtime.CompilerServices;

using JobTrail.Domain.Common;

namespace JobTrail.Domain.Entities;

[Index(nameof(UserId), nameof(Name), IsUnique = true)]
public class Company:BaseEntity
{
    
    public Guid UserId { get; private set; }
    [MaxLength(200)]
    public string Name { get; private set; }
    public string Website { get;private set; }
    public string Location { get; private set; }
    public string Notes { get; private set; }

    protected Company()
    {
        UserId = Guid.Empty;
        Website = null!;
        Location = null!;
        Notes = null!;
    }

    public Company(Guid userId, string name, string website, string location, string notes)
    {
        UserId = userId;
        Name = name;
        Website = website;
        Location = location;
        Notes = notes;
    }
}