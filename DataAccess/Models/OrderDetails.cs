namespace DataAccess.Models;

public class OrderDetails
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int BookId { get; set; }
    public DateTime OrderDate { get; set; }
    public int Pieces { get; set; }
}
