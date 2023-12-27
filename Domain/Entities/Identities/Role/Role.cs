using Domain.Entities.BaseEntity;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities.Identities;

public class Role : IdentityRole<long>, IBaseEntity
{
    
}