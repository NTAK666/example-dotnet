namespace Ecommerce.Models.Dtos;

public record UserUpdate(
    string? Bio,
    string? FullName,
    string? Address 
);