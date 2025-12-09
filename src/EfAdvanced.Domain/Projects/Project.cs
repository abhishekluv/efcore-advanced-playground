using EfAdvanced.Domain.Common;
using EfAdvanced.Domain.ValueObjects;

namespace EfAdvanced.Domain.Projects
{
    public class Project : TenantEntity
    {
        private Project() : base(new TenantId(Guid.Empty)) { } // EF

        public Project(TenantId tenantId, Guid clientId, string name, DateRange period)
            : base(tenantId)
        {
            ClientId = clientId;
            Name = name;
            Period = period;
        }

        public Guid ClientId { get; private set; }
        public string Name { get; private set; } = default!;
        public DateRange Period { get; private set; } = null!;

        public ICollection<WorkItem> WorkItems { get; } = new List<WorkItem>();

        // Concurrency token
        public byte[] RowVersion { get; private set; } = Array.Empty<byte>();
    }
}
