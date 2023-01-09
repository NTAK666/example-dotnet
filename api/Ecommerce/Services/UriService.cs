using Ecommerce.Filters;
using Ecommerce.Services.Interface;
using Microsoft.AspNetCore.WebUtilities;

namespace Ecommerce.Services;

public class UriService : IUriService
{
    private readonly string _baseUri;

    public UriService(string baseUri)
    {
        _baseUri = baseUri;
    }

    public Uri GetPageUri(PaginationFilter filter, string route)
    {
        var endpoint = new Uri(string.Concat(_baseUri, route));
        var modifiedUri = QueryHelpers.AddQueryString(endpoint.ToString(), "pageNumber", filter.PageNumber.ToString());
        modifiedUri = QueryHelpers.AddQueryString(modifiedUri, "pageSize", filter.PageSize.ToString());
        return new Uri(modifiedUri);
    }
}