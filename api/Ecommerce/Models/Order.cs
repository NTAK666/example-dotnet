using Ecommerce.Enum;
using Ecommerce.Models.Dtos;

namespace Ecommerce.Models;

public class Order : BaseEntity
{
    public string? UserId { get; set; } = null!;
    public User? User { get; set; } = null!;
    public OrderStatusEnum Status { get; set; } = OrderStatusEnum.Pending;

    public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public static string GetStatus(OrderStatusEnum status)
    {
        var result = "";
        
        switch (status)
        {
            case OrderStatusEnum.Pending:
                result = "Pending";
                break;
            case OrderStatusEnum.Complete:
                result = "Complete";
                break;
            case OrderStatusEnum.Cancel:
                result = "Cancel";
                break;
            default:
                result = "Pending";
                break;
        }

        return result;
    }
}