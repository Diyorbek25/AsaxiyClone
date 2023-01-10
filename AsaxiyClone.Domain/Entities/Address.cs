namespace AsaxiyClone.Domain.Entities;

public class Address
{
    public Guid Id { get; set; }
    public string? Description { get; set; }
    public short? PostalCode { get; set; }
}