namespace Ecommerce.Models;

public class Product : BaseEntity
{
    public string? Name { get; set; } = null!;
    public string? Price { get; set; } = null!;
    public string? Description { get; set; } = null!;
    public string? Image { get; set; } = null!;
    
    public List<string> Gallary { get; set; } = new List<string>();

    public Category? Category { get; set; } = null!;
    public string? CategoryId { get; set; } = null!;
}