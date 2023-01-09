using Ecommerce.Data;
using Ecommerce.Models;
using Ecommerce.Repositories.Interface;

namespace Ecommerce.Repositories;

public class OrderRepository : BaseRepository<Order>, IOrderRepository
{
    public OrderRepository(AppDbContext context) : base(context)
    {
    }
}