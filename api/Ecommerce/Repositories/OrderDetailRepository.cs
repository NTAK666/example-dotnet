using Ecommerce.Data;
using Ecommerce.Models;
using Ecommerce.Repositories.Interface;

namespace Ecommerce.Repositories;

public class OrderDetailRepository : BaseRepository<OrderDetail>, IOrderDetailRepository
{
    public OrderDetailRepository(AppDbContext context) : base(context)
    {
    }
}