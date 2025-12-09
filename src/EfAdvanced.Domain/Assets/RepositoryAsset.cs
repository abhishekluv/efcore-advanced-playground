using EfAdvanced.Domain.ValueObjects;

namespace EfAdvanced.Domain.Assets
{
    public sealed class RepositoryAsset : Asset
    {
        private RepositoryAsset() { }

        public RepositoryAsset(TenantId tenantId, string name, Uri gitUrl)
            : base(tenantId, name)
        {
            GitUrl = gitUrl;
        }

        public Uri GitUrl { get; private set; } = null!;
    }
}
