using Domain.Entities.Identities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Domain;

public class EzCommerceContext : IdentityDbContext<User,Role,long>
{
    public EzCommerceContext(DbContextOptions<EzCommerceContext> options): base(options)
    {
        
    }
}