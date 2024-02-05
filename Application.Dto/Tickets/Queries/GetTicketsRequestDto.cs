using Application.Dto.Base;
using MediatR;

namespace Application.Dto.Tickets.Queries;

public class GetTicketsRequestDto : IRequest<GenericResponseDto<ListTicketResponseDto>>
{
    public int Page { get; set; }
    public int RecordPage { get; set; }
}
