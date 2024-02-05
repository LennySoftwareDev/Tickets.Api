using Application.Dto.Base;

namespace Application.Dto.Tickets;

public class ListTicketResponseDto : BasePaginationResponseDto
{
    public List<TicketDto>? ListTicketsDto { get; set; }
}