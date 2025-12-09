using EfAdvanced.Domain.ValueObjects;

namespace EfAdvanced.Domain.Billing
{
    public sealed class FixedPriceInvoice : Invoice
    {
        private FixedPriceInvoice() { }

        public FixedPriceInvoice(TenantId tenantId, Guid clientId, DateOnly date, Money fixedAmount)
            : base(tenantId, clientId, date)
        {
            FixedAmount = fixedAmount;
        }

        public Money FixedAmount { get; private set; }
    }
}
