namespace AsaxiyClone.Domain.Entities;

public class Order
{
    public Guid Id { get; set; }

    public decimal TotalPrice { get; set; }
    public decimal DeliveryPrice { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }

    public ICollection<OrderDetail> OrderDetails { get; set; }
    public ICollection<UserHistory> UserHistories { get; set; }
}
