using EfAdvanced.Domain.ValueObjects;

namespace EfAdvanced.Domain.Projects
{
    public sealed class BugWorkItem : WorkItem
    {
        private BugWorkItem() { }

        public BugWorkItem(TenantId tenantId, Guid projectId, string title, string severity)
            : base(tenantId, projectId, title)
        {
            Severity = severity;
        }

        public string Severity { get; private set; } = default!;
    }
}
