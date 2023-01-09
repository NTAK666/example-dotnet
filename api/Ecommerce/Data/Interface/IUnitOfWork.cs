using Ecommerce.Repositories;

namespace Ecommerce.Data.Interface;

public interface IUnitOfWork
{
    public ProductRepository ProductRepository { get; }
    public CategoryRepository CategoryRepository { get; }
    public OrderRepository OrderRepository { get; }
    public OrderDetailRepository OrderDetailRepository { get; }
    void Save();
    void Rollback();
    Task SaveAsync();
    Task RollbackAsync();
}