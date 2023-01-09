namespace Ecommerce.Models.Dtos;

public class TokenDto
{
    public string AccessToken { get; set; } = null!;
    public DateTime TokenExpires { get; set; } 
    public string TokenType { get; set; } = "Bearer";
}