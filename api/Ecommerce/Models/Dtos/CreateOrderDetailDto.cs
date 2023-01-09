namespace Ecommerce.Models.Dtos;

public class CreateOrderDetailDto
{
    public string? ProductId { get; set; } = null!;
    public int Quantity { get; set; } = 0;
}