using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Dtos;

public record SignInDto(
    [Required] string Email,
    [Required] string Password
);