using System.Net;

namespace Application.Dto.Base;

public class ResponseDtoBase : DataTransferObjectBase
{
    public HttpStatusCode StatusCode { get; set; }
    public string StatusDescription { get; set; } = default!;
}