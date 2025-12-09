using EfAdvanced.Domain.ValueObjects;

namespace EfAdvanced.Domain.Projects
{
    public sealed class FeatureWorkItem : WorkItem
    {
        private FeatureWorkItem() { }

        public FeatureWorkItem(TenantId tenantId, Guid projectId, string title, int storyPoints)
            : base(tenantId, projectId, title)
        {
            StoryPoints = storyPoints;
        }

        public int StoryPoints { get; private set; }
    }
}
