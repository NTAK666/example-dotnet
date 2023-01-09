using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Dtos;

public record UploadFileDto(
    [Required] List<IFormFile> Files
);