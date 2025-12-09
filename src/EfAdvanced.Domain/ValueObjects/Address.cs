namespace EfAdvanced.Domain.ValueObjects
{
    public sealed record Address(
    string Line1,
    string? Line2,
    string City,
    string ZipCode,
    string Country);
}
