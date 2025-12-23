using System.Net;

namespace Application.Dtos
{
    public class UseCaseResult
    {
        public object? Content { get; set; }
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
    }
}