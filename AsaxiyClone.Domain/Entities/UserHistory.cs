namespace AsaxiyClone.Domain.Entities;

public class UserHistory
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Order Order { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
}
