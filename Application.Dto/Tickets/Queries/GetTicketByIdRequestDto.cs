using Application.Dto.Base;
using MediatR;

namespace Application.Dto.Tickets.Queries;

public class GetTicketByIdRequestDto : IRequest<GenericResponseDto<TicketDto>>
{
    public int TicketId { get; set; }
}
