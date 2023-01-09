using Ecommerce.Filters;

namespace Ecommerce.Services.Interface;

public interface IUriService
{
    public Uri GetPageUri(PaginationFilter filter, string route);
}