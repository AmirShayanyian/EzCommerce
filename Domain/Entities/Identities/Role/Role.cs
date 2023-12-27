using Domain.Entities.BaseEntity;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities.Identities.Role;

public class Role : IdentityRole<long>, IBaseEntity
{
    
}