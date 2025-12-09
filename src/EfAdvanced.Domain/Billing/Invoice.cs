using EfAdvanced.Domain.Common;
using EfAdvanced.Domain.ValueObjects;

namespace EfAdvanced.Domain.Billing
{
    public abstract class Invoice : TenantEntity
    {
        protected Invoice() : base(new TenantId(Guid.Empty)) { }

        protected Invoice(TenantId tenantId, Guid clientId, DateOnly invoiceDate)
            : base(tenantId)
        {
            ClientId = clientId;
            InvoiceDate = invoiceDate;
        }

        public Guid ClientId { get; private set; }
        public DateOnly InvoiceDate { get; private set; }
        public string Currency { get; private set; } = "GBP";
        public ICollection<InvoiceLine> Lines { get; } = new List<InvoiceLine>();

        public Money Total => Lines.Aggregate(Money.Zero(Currency), (acc, line) => acc + line.LineTotal);
    }
}
