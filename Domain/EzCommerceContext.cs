using Domain.Entities.BaseEntity;
using Domain.Entities.Identities;
using Domain.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Domain;

public class EzCommerceContext : IdentityDbContext<User,Role,long>
{
    public EzCommerceContext(DbContextOptions<EzCommerceContext> options): base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelbuilder)
    {
        base.OnModelCreating(modelbuilder);
        var assemblies = typeof(IBaseEntity).Assembly;
        modelbuilder.AddAllEntities<IBaseEntity>(assemblies);
        modelbuilder.ApplyConfigurationsFromAssembly(typeof(IBaseEntity).Assembly);
    }
}