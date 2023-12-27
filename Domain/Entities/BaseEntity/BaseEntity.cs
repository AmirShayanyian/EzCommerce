namespace Domain.Entities.BaseEntity;

public class BaseEntity : BaseEntity<long>
{
    
}

public class BaseEntity<TKey> : IBaseEntity
{
    public TKey ID { get; set; }
}