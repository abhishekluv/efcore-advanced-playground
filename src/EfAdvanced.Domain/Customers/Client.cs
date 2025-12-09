using EfAdvanced.Domain.Common;
using EfAdvanced.Domain.Projects;
using EfAdvanced.Domain.ValueObjects;

namespace EfAdvanced.Domain.Customers
{
    public class Client : TenantEntity
    {
        private Client() : base(new TenantId(Guid.Empty)) { } // EF

        public Client(TenantId tenantId, string name, Address address) : base(tenantId)
        {
            Name = name;
            Address = address;
        }

        public string Name { get; private set; } = default!;
        public Address Address { get; private set; } = null!;

        public ICollection<Project> Projects { get; } = new List<Project>();
    }
}
