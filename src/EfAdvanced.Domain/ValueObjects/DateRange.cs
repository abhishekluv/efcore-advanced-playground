namespace EfAdvanced.Domain.ValueObjects
{
    public sealed record DateRange(DateOnly? Start, DateOnly? End)
    {
        public bool Contains(DateOnly date)
            => (!Start.HasValue || date >= Start) &&
               (!End.HasValue || date <= End);
    }
}
