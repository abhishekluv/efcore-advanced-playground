using EfAdvanced.Domain.ValueObjects;

namespace EfAdvanced.Domain.Billing
{
    public sealed class TimeAndMaterialInvoice : Invoice
    {
        private TimeAndMaterialInvoice() { }

        public TimeAndMaterialInvoice(TenantId tenantId, Guid clientId, DateOnly date)
            : base(tenantId, clientId, date)
        { }

        public decimal TotalHours { get; private set; }
    }

}
