namespace AsaxiyClone.Domain.Entities;

public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public Guid BookId { get; set; }
    public Book Book { get; set; }
}