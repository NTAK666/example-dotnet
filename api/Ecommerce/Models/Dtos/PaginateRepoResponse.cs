namespace Ecommerce.Models.Dtos;

public class PaginateRepoResponse<T>
{
    public int TotalRecord { get; set; }
    public IEnumerable<T> Data { get; set; } = null!;
}