using Ecommerce.Data;
using Ecommerce.Models;
using Ecommerce.Repositories.Interface;

namespace Ecommerce.Repositories;

public class ProductRepository : BaseRepository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext context) : base(context)
    {
    }
}