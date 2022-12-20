namespace DataAccess.Models;

public class User
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string UserName { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public Gender Gender { get; set; }
}

public enum Gender
{
    Male,
    Female
}
