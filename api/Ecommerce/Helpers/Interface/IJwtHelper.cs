using System.Security.Claims;
using Ecommerce.Models;

namespace Ecommerce.Helpers.Interface;

public interface IJwtHelper
{
    public string GenerateToken(User model, List<string>? roles = null);
    public string GenerateRefreshToken();
    public ClaimsPrincipal? GetPrincipalFromExpiredToken(string? token);
}