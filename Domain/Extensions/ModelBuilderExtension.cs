using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Domain.Extensions;

public static class ModelBuilderExtension
{
    public static void AddAllEntities<TBaseType>(this ModelBuilder modelBuilder, params Assembly[] assemblies)
    {
        var entityTypes = assemblies
            .SelectMany(x => x.GetExportedTypes())
            .Where(p => p is { IsPublic: true, IsAbstract: false } && typeof(TBaseType)
                            .IsAssignableFrom(p) &&
                        p.IsSubclassOf(typeof(TBaseType)));
        foreach (var type in entityTypes)
        {
            modelBuilder.Entity(type);
        }
    }
}