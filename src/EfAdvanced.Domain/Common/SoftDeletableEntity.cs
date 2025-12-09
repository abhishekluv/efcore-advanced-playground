namespace EfAdvanced.Domain.Common
{
    public abstract class SoftDeletableEntity : EntityBase, ISoftDeletable
    {
        public bool IsDeleted { get; protected set; }
        public DateTimeOffset? DeletedAt { get; protected set; }

        public void MarkDeleted(DateTimeOffset? deletedAt = null)
        {
            IsDeleted = true;
            DeletedAt = deletedAt ?? DateTimeOffset.UtcNow;
        }
    }
}
