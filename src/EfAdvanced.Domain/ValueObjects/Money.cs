namespace EfAdvanced.Domain.ValueObjects
{
    public sealed record Money(decimal Amount, string Currency)
    {
        public static Money Zero(string currency) => new(0m, currency);

        public static Money operator +(Money left, Money right)
        {
            if (left.Currency != right.Currency)
                throw new InvalidOperationException("Cannot add different currencies.");

            return new Money(left.Amount + right.Amount, left.Currency);
        }

        public override string ToString() => $"{Currency} {Amount:N2}";
    }
}
