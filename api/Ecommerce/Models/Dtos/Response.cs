using System.Net;

namespace Ecommerce.Models.Dtos;

public class Response
{
    public object Data { get; set; } = null!;
    public string Message { get; set; } = null!;
    public HttpStatusCode StatusCode { get; set; }

    public Response()
    {
        
    }
}