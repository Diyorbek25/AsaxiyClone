namespace AsaxiyClone.Domain.Entities;

public class OrderDetail
{
    public Guid Id { get; set; }

    public Guid OrderId { get; set; }
    public Order Order { get; set; }
    public Guid BookId { get; set; }
    public Book Book { get; set; }

    public decimal BookPrice { get; set; }
    public DateTime OrderTime { get; set; }
    public DateTime DeliveryTime { get; set; }
}
