using Domain.Entities.BaseEntity;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities.Identities.User;

public class User : IdentityUser<long>, IBaseEntity
{
    
}