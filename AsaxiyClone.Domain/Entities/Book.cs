using AsaxiyClone.Domain.Entities.Enums;

namespace AsaxiyClone.Domain.Entities;

public class Book
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Image { get; set; }
    public decimal Price { get; set; }
    public BookStatus Status { get; set; }
    public string Author { get; set; }
    public int? Rating { get; set; }

    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
    public ICollection<Comment>? Comments { get; set; }
}
