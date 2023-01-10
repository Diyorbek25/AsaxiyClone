namespace AsaxiyClone.Domain.Entities;

public class Book
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public decimal Price { get; set; }
    public Status Status { get; set; }
}
