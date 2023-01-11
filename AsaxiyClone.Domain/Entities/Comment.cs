namespace AsaxiyClone.Domain.Entities;

public class Comment
{
    public Guid Id { get; set; }
    public string Body { get; set; }
    public DateTime Date { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }

    public Guid BookId { get; set; }
    public Book Book { get; set; }
}
