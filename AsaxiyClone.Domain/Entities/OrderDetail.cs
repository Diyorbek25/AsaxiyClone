namespace AsaxiyClone.Domain.Entities;

public class OrderDetail
{
    public Guid Id { get; set; }
    public decimal BookPrice { get; set; }
    public DateTime OrderTime { get; set; }
    public DateTime DeliveryTime { get; set; }
}
