using EfAdvanced.Domain.Common;
using EfAdvanced.Domain.ValueObjects;

namespace EfAdvanced.Domain.Assets
{
    public abstract class Asset : TenantEntity
    {
        protected Asset() : base(new TenantId(Guid.Empty)) { }

        protected Asset(TenantId tenantId, string name) : base(tenantId)
        {
            Name = name;
        }

        public string Name { get; private set; } = default!;
    }
}
