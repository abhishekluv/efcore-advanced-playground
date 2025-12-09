using EfAdvanced.Domain.ValueObjects;

namespace EfAdvanced.Domain.Billing
{
    public class InvoiceLine
    {
        private InvoiceLine() { }

        public InvoiceLine(Guid invoiceId, string description, decimal quantity, Money unitPrice)
        {
            InvoiceId = invoiceId;
            Description = description;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public Guid Id { get; private set; } = Guid.NewGuid();
        public Guid InvoiceId { get; private set; }
        public string Description { get; private set; } = default!;
        public decimal Quantity { get; private set; }
        public Money UnitPrice { get; private set; } = null!;

        public Money LineTotal => new(UnitPrice.Amount * Quantity, UnitPrice.Currency);
    }
}
