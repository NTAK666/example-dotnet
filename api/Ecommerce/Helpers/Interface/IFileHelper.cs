namespace Ecommerce.Helpers.Interface;

public interface IFileHelper
{
    public Task<List<string>> Store(List<IFormFile> files);
}