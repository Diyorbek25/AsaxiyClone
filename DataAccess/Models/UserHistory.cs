namespace DataAccess.Models;

public class UserHistory
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int OrderId { get; set; }

    public DateTime Date { get; set; }
}
