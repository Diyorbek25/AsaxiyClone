using AsaxiyClone.Domain.Entities.Enums;

namespace AsaxiyClone.Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public string  PhoneNumber { get; set; }
    public string?  Email { get; set; }
    public Gender? Gender { get; set; }
    
    public Guid AddressId { get; set; }
    public Address Address { get; set; }

    public Bucket Bucket { get; set; }

    public ICollection<Order> Orders { get; set; }
    public ICollection<Comment> Comments { get; set; }
    public ICollection<UserHistory> UserHistories { get; set; }
}
