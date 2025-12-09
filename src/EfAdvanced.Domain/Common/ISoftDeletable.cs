namespace EfAdvanced.Domain.Common
{
    public interface ISoftDeletable
    {
        bool IsDeleted { get; }
        DateTimeOffset? DeletedAt { get; }
        void MarkDeleted(DateTimeOffset? deletedAt = null);
    }
}
