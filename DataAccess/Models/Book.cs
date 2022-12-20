namespace DataAccess.Models;
public class JustBook
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public decimal Price{ get; set; }
    public byte Status { get; set; }
    public string Author { get; set; }
    public int Raiting { get; set; }
    public int Category_Id { get; set; }

}
