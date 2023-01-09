using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Models;

public class User : IdentityUser
{
    public string? Bio { get; set; }
    public string? FullName { get; set; }
    public string? Avatar { get; set; }
    public string? Address { get; set; }
    public bool IsDeleted { get; set; } = false;
}