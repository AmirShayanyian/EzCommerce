using Domain.Entities.BaseEntity;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities.Identities;

public class User : IdentityUser<long>, IBaseEntity
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }
}