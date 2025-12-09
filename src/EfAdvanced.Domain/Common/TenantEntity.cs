using EfAdvanced.Domain.ValueObjects;

namespace EfAdvanced.Domain.Common
{
    public abstract class TenantEntity : SoftDeletableEntity
    {
        public TenantId TenantId { get; protected set; }

        protected TenantEntity(TenantId tenantId)
        {
            TenantId = tenantId;
        }
    }
}
