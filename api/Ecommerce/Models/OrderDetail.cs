namespace Ecommerce.Models;

public class OrderDetail : BaseEntity
{
    public string? ProductId { get; set; } = null!;
    public Product? Product { get; set; } = null!;
    
    public int Quantity { get; set; } = 0;
    
    public string? OrderId { get; set; } = null!;
    public Order? Order { get; set; } = null!;
}