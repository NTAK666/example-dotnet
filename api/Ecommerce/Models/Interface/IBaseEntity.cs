namespace Ecommerce.Models.Interface;

public interface IBaseEntity
{
    string Id { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
}