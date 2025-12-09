using EfAdvanced.Domain.ValueObjects;

namespace EfAdvanced.Domain.Projects
{
    public sealed class SupportWorkItem : WorkItem
    {
        private SupportWorkItem() { }

        public SupportWorkItem(TenantId tenantId, Guid projectId, string title, string customerContact)
            : base(tenantId, projectId, title)
        {
            CustomerContact = customerContact;
        }

        public string CustomerContact { get; private set; } = default!;
    }
}
