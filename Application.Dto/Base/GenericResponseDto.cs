using System.Net;

namespace Application.Dto.Base;

public class GenericResponseDto<TGeneric>
{
    public TGeneric? Result { get; set; }
    public HttpStatusCode StatusCode { get; set; }
    public string? StatusDescription { get; set; }
    public List<string>? Errors { get; set; }
}