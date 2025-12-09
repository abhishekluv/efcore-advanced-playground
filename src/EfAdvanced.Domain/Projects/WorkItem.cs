using EfAdvanced.Domain.Common;
using EfAdvanced.Domain.ValueObjects;

namespace EfAdvanced.Domain.Projects
{
    public abstract class WorkItem : TenantEntity
    {
        protected WorkItem() : base(new TenantId(Guid.Empty)) { }

        protected WorkItem(TenantId tenantId, Guid projectId, string title)
            : base(tenantId)
        {
            ProjectId = projectId;
            Title = title;
        }

        public Guid ProjectId { get; protected set; }
        public string Title { get; protected set; } = default!;
        public string? Description { get; protected set; }
        public WorkItemStatus Status { get; protected set; } = WorkItemStatus.Open;
    }

    public enum WorkItemStatus { Open, InProgress, Done, Cancelled }
}
