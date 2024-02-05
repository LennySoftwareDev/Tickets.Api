using Application.Dto.Base;
using System.Net;

namespace Syp.Pi.Aplication.Dto.Base;

public class RequestDtoBase : DataTransferObjectBase
{
    public HttpStatusCode StatusCode { get; set; }
    public string StatusDescription { get; set; } = default!;
}