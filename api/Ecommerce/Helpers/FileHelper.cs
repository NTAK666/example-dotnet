using Ecommerce.Helpers.Interface;
using MimeTypes;

namespace Ecommerce.Helpers;

public class FileHelper : IFileHelper
{
    private readonly IWebHostEnvironment _environment;
    private readonly IConfiguration _configuration;

    public FileHelper(IWebHostEnvironment environment, IConfiguration configuration)
    {
        _environment = environment;
        _configuration = configuration;
    }

    public async Task<List<string>> Store(List<IFormFile> files)
    {
        var directoryPath = Path.Combine(_environment.WebRootPath, "resources");
        
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        var urlApp = $"{_configuration["App:Url"]}/resources";

        var listUrl = new List<string>();
        
        foreach (var file in files)
        {
            var extension = file.FileName.Split(".")[1];
            var fileName = $"{Guid.NewGuid().ToString()}.{extension}";
            
            var filePath = Path.Combine(directoryPath, fileName);
            var fileUrl = $"{urlApp}/{fileName}";
            listUrl.Add(fileUrl);
            
            await using var stream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(stream);
        }

        return listUrl;
    }
}