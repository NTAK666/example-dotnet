using Ecommerce.Data.Interface;
using Ecommerce.Repositories;

namespace Ecommerce.Data;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    private ProductRepository _productRepository = null!;
    private CategoryRepository _categoryRepository = null!;
    private OrderRepository _orderRepository = null!; 
    private OrderDetailRepository _orderDetailRepository = null!;
    
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public ProductRepository ProductRepository =>
        _productRepository = _productRepository ?? new ProductRepository(_context);

    public CategoryRepository CategoryRepository =>
        _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);

    public OrderRepository OrderRepository =>
        _orderRepository = _orderRepository ?? new OrderRepository(_context);

    public OrderDetailRepository OrderDetailRepository =>
        _orderDetailRepository = _orderDetailRepository ?? new OrderDetailRepository(_context);
    
    public void Save() => _context.SaveChanges();
    public void Rollback() => _context.Dispose();
    public async Task SaveAsync() => await _context.SaveChangesAsync();
    public async Task RollbackAsync() => await _context.DisposeAsync();
}