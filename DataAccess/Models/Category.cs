

namespace DataAccess.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int BookId { get; set; }
    public Category ParentCategory { get; set; }    
}
