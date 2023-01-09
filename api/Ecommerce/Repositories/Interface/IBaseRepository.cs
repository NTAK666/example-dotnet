using System.Linq.Expressions;
using Ecommerce.Filters;
using Ecommerce.Models;
using Ecommerce.Models.Dtos;

namespace Ecommerce.Repositories.Interface;

public interface IBaseRepository<TEntity> where TEntity : BaseEntity
{
    Task<IEnumerable<TEntity>> FindAll(string? relations = "");

    Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate,
        string? relations = "", string? orderByQueryString = "");

    Task<PaginateRepoResponse<TEntity>> Paginate(PaginationFilter? paginationFilter = null,
        Expression<Func<TEntity, bool>>? predicate = null, string? relations = "", string? orderByQueryString = "");

    Task<TEntity?> FindById(string id, string? relations = "");
    public Task<int> CountAsync();
    public int Count();
    Task Add(TEntity entity);
    void Update(TEntity entity);
    void UpdateRange(List<TEntity> entities);
    void Delete(TEntity entity);
    void Delete(string id);
    void DeleteRange(List<TEntity> entities);
    void SoftDelete(string id);
}