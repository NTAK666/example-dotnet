namespace Ecommerce.Models.Dtos;

public record AddOrderDto(
    List<CreateOrderDetailDto> OrderDetails
);