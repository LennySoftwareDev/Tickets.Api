using Application.Dto.Base;
using MediatR;

namespace Application.Dto.Tickets.Commands;

public class DeleteTicketRequestDto : IRequest<GenericResponseDto<bool>>
{
    public int TicketId { get; set; }
}
