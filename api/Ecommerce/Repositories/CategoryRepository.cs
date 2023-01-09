using Ecommerce.Data;
using Ecommerce.Models;
using Ecommerce.Repositories.Interface;

namespace Ecommerce.Repositories;

public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    public CategoryRepository(AppDbContext context) : base(context)
    {
    }
}