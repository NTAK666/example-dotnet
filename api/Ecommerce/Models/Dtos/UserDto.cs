namespace Ecommerce.Models.Dtos;

public class UserDto : BaseEntity
{
    public string? Bio { get; set; }
    public string? Email { get; set; }
    public string? UserName { get; set; }
    public string? FullName { get; set; }
    public string? Avatar { get; set; }
    public string? Address { get; set; }   
}