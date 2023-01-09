using Ecommerce.Enum;

namespace Ecommerce.Models.Dtos;

public class OrderDto
{
    public UserDto? User { get; set; } = null!;
    public List<OrderDetailDto> OrderDetails { get; set; } = new List<OrderDetailDto>();
    public OrderStatusEnum Status { get; set; }
}