using EfAdvanced.Domain.ValueObjects;

namespace EfAdvanced.Domain.Assets
{
    public sealed class DocumentAsset : Asset
    {
        private DocumentAsset() { }

        public DocumentAsset(TenantId tenantId, string name, string filePath)
            : base(tenantId, name)
        {
            FilePath = filePath;
        }

        public string FilePath { get; private set; } = default!;
    }
}
