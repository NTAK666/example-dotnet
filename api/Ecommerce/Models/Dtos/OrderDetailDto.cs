namespace Ecommerce.Models.Dtos;

public class OrderDetailDto
{
    public Product? Product { get; set; } = null!;
    public int Quantity { get; set; } = 0;
}