namespace AsaxiyClone.Domain.Entities;

public class Basket
{
    public Guid Id { get; set; }
    public int Pieces { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }

    public Guid BookId { get; set; }
    public Book Book { get; set; }
}
